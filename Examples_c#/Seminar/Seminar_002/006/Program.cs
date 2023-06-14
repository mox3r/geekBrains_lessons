//Рандомное число (10-99) и вывод наибольшего числа.
Console.Write("Случайное число: ");
int num = new Random().Next(10, 100);
System.Console.WriteLine(num);

System.Console.WriteLine("Наибольшее: " + MaxDigit(num));

int MaxDigit(int num)
{
    int first = num / 10;
    int second = num % 10;
    if (first > second) return first;
    else return second;
}