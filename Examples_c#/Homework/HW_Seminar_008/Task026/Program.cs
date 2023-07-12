int InputNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int sizeM)
{
    return new int[sizeM, sizeM];
}

void Fill2DArray(int[,] array, int minValue)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
        array[0, j] = minValue;
        minValue++;
    }
    for (int i = 1; i < array.GetLength(0) - 1; i++)
    {
        array[i, array.GetLength(1) - 1] = minValue;
        minValue++;
    }
    for (int j = array.GetLength(0) - 1; j >= 0; j--)
    {
        array[array.GetLength(0) - 1, j] = minValue;
        minValue++;
    }
    for (int i = array.GetLength(0) - 2; i >= 1; i--)
    {
        array[i, 0] = minValue;
        minValue++;
    }
    for (int j = 1; j < array.GetLength(1) - 1; j++)
    {
        array[1, j] = minValue;
        minValue++;
    }
    for (int i = array.GetLength(1) - 2; i >= 1 ; i--)
    {
        array[array.GetLength(1) -2, i] = minValue;
        minValue++;
    }
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
    Console.WriteLine("Спиральное заполнение матрицы 4х4, шаг 1");
    int minValue;
    try
    {
        minValue = InputNumber("Введите начальное значение элементов: ");
    }
    catch (Exception)
    {
        Console.WriteLine("Вы ввели неверное значение!");
        Console.ReadLine();
        continue;
    }
    const int SIZE = 4;
    int[,] array = Create2DArray(SIZE);
    Fill2DArray(array, minValue);
    Print2DArray(array);



    Console.ReadLine();
}