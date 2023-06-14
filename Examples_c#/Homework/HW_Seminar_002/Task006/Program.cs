// Вывести третью цифру числа
System.Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
if (num <= 99 && num > -99)
{
    System.Console.WriteLine("В этом числе нет нужного колличества знаков!");
}
else
{
    int count = 0;
    int i = 1;
    int fret = 1;
    while (num / i != 0)
    {
        count++;
        i *= 10;
    }
    System.Console.WriteLine("Разрядов у числа: " + count);
    for (i = 0; i < count - 3; i++)
    {
        fret *= 10;
    }
    int result = (num / fret) % 10;
    System.Console.WriteLine($"Третий разряд у числа: {result}");
}