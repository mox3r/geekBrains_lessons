﻿int InputNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,,] Create3DArray(int sizeM, int sizeN, int sizeK)
{
    return new int[sizeM, sizeN, sizeK];
}

void Fill3DArray(int[,,] array, int minValue, int maxValue)
{
    Random rnd = new Random();
    bool isThere = false;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2);)
            {
                int newRandomVal = rnd.Next(minValue, maxValue+1);
                for (int x = 0; x < k; x++)

                    if (array[i, j, k] == newRandomVal)
                        isThere = true;

                if (!isThere)
                {
                    array[i, j, k] = newRandomVal;
                    k++;
                }
            }
}


void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i, j, k]}({i},{j},{k})\t");
            Console.WriteLine();
        }
}



while (true)
{
    Console.Clear();
    Console.WriteLine("Трехмерный массив, не повторяющиеся двузначные эл-ты, вывод с индексами.");
    int sizeM, sizeN, sizeK, minValue, maxValue;
    try
    {
        sizeM = InputNumber("Введите число строк: ");
        sizeN = InputNumber("Введите число столбцов: ");
        sizeK = InputNumber("Введите число глубины: ");
        minValue = InputNumber("Введите минимальное значение в массиве: ");
        maxValue = InputNumber("Введите максимальное значение в массиве: ");
    }
    catch (Exception)
    {
        Console.WriteLine("Вы ввели неверное значение!");
        Console.ReadLine();
        continue;
    }

    int[,,] array = Create3DArray(sizeM, sizeN, sizeK);
    Fill3DArray(array, minValue, maxValue);
    Print3DArray(array);

    Console.ReadLine();
}