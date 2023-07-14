System.Console.WriteLine("Вывод N -> 1. Рекурсия");
int InputNum(string msg)
{
    System.Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

int RecNumber(int n)
{
    if (n < 2) return 1;
    System.Console.Write($"{n}, ");
    return RecNumber(n - 1);
}

int n = InputNum("Введите число: ");

System.Console.Write(RecNumber(n));