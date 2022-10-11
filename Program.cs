Console.WriteLine("Введите строки (для завершения нажмите Enter):");

int count = 0;
string[] ArrString = new string[count];
string s;
do
{
    s = Console.ReadLine();

    if (s != "")
    {
        count++;
        string[] ArrString2 = new string[count];

        for (int i = 0; i < ArrString2.Length - 1; i++)
            ArrString2[i] = ArrString[i];

        ArrString2[count - 1] = s;

        ArrString = ArrString2;
    }
}
while (s != "");

Console.WriteLine("[" + string.Join(", ", ArrString) + "]");
