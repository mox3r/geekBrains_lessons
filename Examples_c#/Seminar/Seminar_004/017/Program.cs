long InputNum(string msg)
{
    System.Console.Write(msg);
    return long.Parse(Console.ReadLine()!);
}

long NumMultiple(long num)
{
    long result = 1;
    for (long i = 1; i <= num; i++)
    {
        result *= i;
    }
    return result;
}
System.Console.WriteLine("Представление n!");

long num = InputNum("Введите число n: ");
long res = NumMultiple(num);

System.Console.WriteLine($"n! = {res}");