int InputNum(string msg)
{
    System.Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}
int SummCounter(int summ)
{
    int result = summ;
    for (int i = summ - 1; i >= 0; --i)
    {
        result += i;
    }
    return result;
}
System.Console.WriteLine("Сумма всех чисел числа.");
int summ = InputNum("Введите число: ");
int result = SummCounter(summ);
System.Console.WriteLine($"Результат: {result}");