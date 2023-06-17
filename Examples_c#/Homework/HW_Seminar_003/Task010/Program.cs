int InpMSG(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int PowRow(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.Write(Math.Pow(i, 3));
        if (i < num)
            System.Console.Write(", ");
    }
    return 0;
}

System.Console.WriteLine("Кубический степенной ряд.");
int num = InpMSG("Введите количество чисел: ");

PowRow(num);