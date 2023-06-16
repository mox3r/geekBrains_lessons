// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int Quaters(int x, int y)
{
    if (x > 0 && y > 0) Console.WriteLine("Точка находится в первой четверти графика!");
    else if (x > 0 && y < 0) Console.WriteLine("Точка находится во второй четверти графика!");
    else if (x < 0 && y < 0) Console.WriteLine("Точка находится в третьей четверти графика!");
    else if (x < 0 && y > 0) Console.WriteLine("Точка находится в четвертой четверти графика!");
    else System.Console.WriteLine("Точка находится на пересечении четвертей!");
    return 0;
}
Console.Write("Введите число x: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите число y: ");
int y = int.Parse(Console.ReadLine()!);
Quaters(x, y);