System.Console.WriteLine("Функция Аккермана. Рекурсия");
int InputNum (string msg)
{
    System.Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

int AckermanF (int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return AckermanF(m - 1, 1);
    if (m > 0 && n > 0) return AckermanF(m - 1, AckermanF(m, n - 1));
return AckermanF(m, n);
}

int m = InputNum("Введите число: ");
int n = InputNum("Введите число: ");

System.Console.Write(AckermanF(m,n));