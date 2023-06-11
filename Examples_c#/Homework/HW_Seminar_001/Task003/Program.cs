// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

System.Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

switch (a % 2)
{
    case 1:
        System.Console.WriteLine("Нечетное");
        break;
    case 0:
        System.Console.WriteLine("Четное");
        break;
}
