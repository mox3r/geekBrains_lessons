System.Console.WriteLine("Сумма чисел на промежутке [M,N]. Рекурсия");
int InputNum(string msg)
{
    System.Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

int SummNumber(int m, int n)
{
    if(m==n) return n;
    else return n + SummNumber(m, n -1);
}

int m = InputNum("Введите число: ");
int n = InputNum("Введите число: ");
System.Console.Write($"Сумма на промежутке [{m};{n}] равна {SummNumber(m, n)}");