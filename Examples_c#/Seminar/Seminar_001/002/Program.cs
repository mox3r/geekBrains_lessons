//Сравнивает является ли первое число квадратом второго
System.Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine()!);
System.Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine()!);
System.Console.Write("Проверка 'первое ли квадрат второго?': ");

if (num1 == num2*num2)
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}