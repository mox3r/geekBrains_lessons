﻿System.Console.Write("Введите размер массива: ");
int arrLenght = int.Parse(Console.ReadLine()!);
int[] arr = new int[arrLenght];

FillArray();
System.Console.Write("Массив:");
PrintArray();

System.Console.WriteLine("\n");

System.Console.Write("Введите запрашиваемое число: ");
int find = int.Parse(Console.ReadLine());

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] == find)
    {
        System.Console.WriteLine($"Находится под позицией {i}");
        break;
    }
    else
    {
        System.Console.WriteLine("Совпадений не найдено");
        break;
    }
}

void FillArray()
{
    for (int i = 0; i < arrLenght; i++)
    {
        arr[i] = new Random().Next(0, 101);
    }
}

void PrintArray()
{
    for (int i = 0; i < arrLenght; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
}
//Альтернативная запись.