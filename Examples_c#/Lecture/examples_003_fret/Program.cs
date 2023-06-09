// Console.Write("Введите числитель: ");
// int num1 = Console.ReadLine();
// Console.Write("Введите знаменатель: ");
// int num2 = Console.ReadLine();

double num1 = new Random().Next(-100,1001); // Рандом -100 - 1000
Console.Write("Делимое равно: ");
Console.WriteLine(num1);
double num2 = new Random().Next(-100, 101);
Console.Write("Делитель равен: ");
Console.WriteLine(num2);
if (num2 == 0)
{
    Console.WriteLine("Ошибка001: на ноль делить нельзя!");
}
else
{
    Console.Write("Частное равно: ");
    Console.WriteLine(num1/num2);
}
