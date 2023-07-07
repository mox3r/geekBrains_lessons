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



while (true)
{
    Console.Clear();
    Console.WriteLine("");
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


    Console.ReadLine();
}