﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите целое число: ");
int a = int.Parse(Console.ReadLine());
int i = 2; //можно "0" тогда счет от нуля пойдёт

while (i <= a)
{
    Console.Write(i);
    i += 2;
    if (i <= a)
        Console.Write(", ");
}