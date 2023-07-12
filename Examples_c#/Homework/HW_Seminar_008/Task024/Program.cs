int InputNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int sizeM, int sizeN)
{
    return new int[sizeM, sizeN];
}

void Fill2DArray(int[,] array)
{
    try
    {
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
                array[i, j] = InputNumber("Введите элемент матрицы: ");
    }
    catch (Exception)
    {
        System.Console.WriteLine("Вы ввели неверное значение!");
        Console.ReadLine();
        
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

void Multiple2dArrays(int[,] arr1, int[,] arr2)
{
    if (arr1.GetLength(1) == arr2.GetLength(0))
    {
        int[,] arrResult = Create2DArray(arr1.GetLength(0), arr2.GetLength(1));
        int temp = 0;

        for (int i = 0; i < arr1.GetLength(0); i++)
            for (int j = 0; j < arr2.GetLength(1); j++)
            {
                for (int k = 0; k < arr1.GetLength(1); k++)
                    temp += arr1[i, k] * arr2[k, j];

                arrResult[i, j] = temp;
                temp = 0;
            }

        Print2DArray(arrResult);

    }
    else Console.WriteLine("Произведение матриц не определено!");
}


while (true)
{
    Console.Clear();
    Console.WriteLine("Умножение матриц.");
    int sizeM, sizeN, sizeX, sizeY;
    try
    {
        sizeM = InputNumber("Введите число строк первой матрицы: ");
        sizeN = InputNumber("Введите число столбцов первой матрицы: ");
        sizeX = InputNumber("Введите число строк второй матрицы: ");
        sizeY = InputNumber("Введите число столбцов второй матрицы: ");
    }
    catch (Exception)
    {
        Console.WriteLine("Вы ввели неверное значение!");
        Console.ReadLine();
        continue;
    }

    int[,] array1st = Create2DArray(sizeM, sizeN);
    int[,] array2nd = Create2DArray(sizeX, sizeY);
    Console.WriteLine("Заполняем первую матрицу:");
    Fill2DArray(array1st);
    Console.WriteLine("Заполняем вторую матрицу:");
    Fill2DArray(array2nd);
    Console.WriteLine("Первая матрица:");
    Print2DArray(array1st);
    Console.WriteLine("Вторая матрица:");
    Print2DArray(array2nd);
    Console.WriteLine("Результирующая матрица:");
    Multiple2dArrays(array1st, array2nd);

    Console.ReadLine();
}