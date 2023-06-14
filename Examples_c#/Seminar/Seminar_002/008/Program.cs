//Проверка на кратность одного числа к другому


System.Console.Write("Введите первое число: ");
int num1 = Numcatch();
System.Console.Write("Введите второе число: ");
int num2 = Numcatch();

if (num1 % num2 == 0)
{
    System.Console.WriteLine("Кратно");
}
else
{
    System.Console.WriteLine("Не кратно");
}


int Numcatch()
{
    int num = int.Parse(Console.ReadLine()!);
    return num;
}