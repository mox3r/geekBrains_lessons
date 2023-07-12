int InputNumber(string message)
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

void WOPosMin(int[,] array)
{
    int minI = 0, minJ = 0, minN = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[minI, minJ] > array[i, j])
            {
                minI = i;
                minJ = j;
            }
        }
    }

    Console.WriteLine($"Минимальный эл-т {minN}: столбец {minJ + 1}, строка {minI + 1}");

    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == minI) continue;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == minJ) continue;
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}


while (true)
{
    Console.Clear();
    Console.WriteLine("Удалить из матрицы строку и столбец на пересечении которых находится минимальный эл-т массива.");
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
    Console.WriteLine("Результирующий массив:");
    WOPosMin(array);

    Console.ReadLine();
}