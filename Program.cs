string[] GetShortWordsArray(string[] array)
{
    string[] resultArr = new string[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        {
        resultArr[count] = array[i];
        count++;
        }
    }
    Array.Resize(ref resultArr, count);
    return resultArr;
}


Console.WriteLine("Введите строки (для завершения нажмите Enter):");

int count = 0;
string[] arrString = new string[count];
string s = "";
do
{
    s = Console.ReadLine();

    if (s != "")
    {
        count++;
        string[] arrStringNew = new string[count];

        for (int i = 0; i < arrStringNew.Length - 1; i++)
            arrStringNew[i] = arrString[i];

        arrStringNew[count - 1] = s;

        arrString = arrStringNew;
    }
}
while (s != "");

GetShortWordsArray(arrString);
Console.WriteLine("[" + string.Join(", ", GetShortWordsArray(arrString)) + "]");