// Принимает на вход число и выдаёт кол-во чисел в числе;

int InputNum(string msg)
{
    System.Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

int NumCount(int num)
{
    int count = 0;
    while (num != 0)
    {
        num /= 10;
        count++;
    }
    return count;
}

int num = InputNum("Вчедите число: ");
System.Console.WriteLine($"В числе {num} {NumCount(num)} разрядов");
