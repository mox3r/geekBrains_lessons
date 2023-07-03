Console.WriteLine("Массив mxn. Заполнение случайными вещественными.");

int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

double[,] Create2DArray(int sizeM, int sizeN)
{
    return new double[sizeM, sizeN];
}

void Print2DArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void Fill2DArray(double[,] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(100)
                        + Math.Round(rnd.NextDouble(), 2);
        }
    }
}

int sizeM = InputNum("Введите количество строк: ");
int sizeN = InputNum("Введите количество столбцов: ");

double[,] arr = Create2DArray(sizeM, sizeN);
Fill2DArray(arr);
Print2DArray(arr);
