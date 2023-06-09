//Число в день недели
System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 1)
{
    System.Console.WriteLine("Понедельник");
}
if (num == 2)
{
    System.Console.WriteLine("Вторник");
}
if (num == 3)
{
    System.Console.WriteLine("Среда");
}
if (num == 4)
{
    System.Console.WriteLine("Четверг");
}
if (num == 5)
{
    System.Console.WriteLine("Пятница");
}
if (num == 6)
{
    System.Console.WriteLine("Суббота");
}
if (num == 7)
{
    System.Console.WriteLine("Воскресение");
}
if (num < 1 || num > 7)
{
    System.Console.WriteLine("Дней недели всего 7 :)");
}