﻿Console.WriteLine("Массив, рандомная длина, значения. Перевести их в аналог с противоположным знаком.");

int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

int[] NewArr(int size)
{
    return new int[size];
}

void FillArray(int[] arr, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
        arr[i] = rnd.Next(min, max + 1);

}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < arr.Length - 1) Console.Write(", ");
        else Console.WriteLine("]");
    }
}

void RevNum(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
}

int size = InputNum("Введите размер массива: ");
int minVal = InputNum("Введите минимальное значение массива: ");
int maxVal = InputNum("Введите максимальное значение массива: ");
int[] arr = NewArr(size);

FillArray(arr, minVal, maxVal);
PrintArray(arr);
Console.WriteLine("Новый массив:");
RevNum(arr);
PrintArray(arr);
