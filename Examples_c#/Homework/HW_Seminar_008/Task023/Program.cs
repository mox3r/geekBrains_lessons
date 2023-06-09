﻿int InputNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int sizeM, int sizeN)
{
    return new int[sizeM, sizeN];
}

void Fill2DArray(int[,] array, int minValue, int maxValue)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(minValue, maxValue + 1);
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}

void Sort2dArray(int[,] array)
{
    int summ = 0, index = 0, temp = summ;
    int[] arrRes = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        summ = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ += array[i, j];
        }
        arrRes[index] = summ;
        index++;
    }
    index = 0;
    for (int k = 1; k < arrRes.Length; k++)
    {
        if (arrRes[k] < arrRes[index]) index = k;
    }
    Console.WriteLine($"Наименьшая сумма в строке {index + 1}");
}


while (true)
{
    Console.Clear();
    Console.WriteLine("Наименьшая сумма в строке.");
    int sizeM, sizeN, minValue, maxValue;
    try
    {
        sizeM = InputNumber("Введите число строк: ");
        sizeN = InputNumber("Введите число столбцов: ");
        minValue = InputNumber("Введите минимальное значение в массиве: ");
        maxValue = InputNumber("Введите максимальное значение в массиве: ");
    }
    catch (Exception)
    {
        Console.WriteLine("Вы ввели неверное значение!");
        Console.ReadLine();
        continue;
    }

    int[,] array = Create2DArray(sizeM, sizeN);
    Fill2DArray(array, minValue, maxValue);
    Print2DArray(array);
    Sort2dArray(array);


    Console.ReadLine();
}