// Проверка числа на Кратность 7 и 23
Console.Write("Введите число: ");
int number = NumCatch();

if (number % 23 == 0 && number % 7 == 0)
{
    System.Console.WriteLine("Кратно");
}
else
{
    System.Console.WriteLine("Не кратно");
}

int NumCatch()
{
    int num = int.Parse(Console.ReadLine()!);
    return num;
}