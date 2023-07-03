Console.WriteLine("Массив mxn. Найти среднее значение столбцов.");

int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int sizeM, int sizeN)
{
    return new int[sizeM, sizeN];
}

void Print2DArray(int[,] arr)
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

void Fill2DArray(int[,] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(100);
        }
    }
}

void Transpose2DArray(int[,] arr, int[,] arrT)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arrT[j, i] = arr[i, j];
        }
    }
}

void AvgCols(int[,] arr)
{
    int[,] arrT = Create2DArray(arr.GetLength(1), arr.GetLength(0));
    Transpose2DArray(arr, arrT);

    for (int i = 0; i < arrT.GetLength(0); i++)
    {
        int colSumm = 0;
        for (int j = 0; j < arrT.GetLength(1); j++)
        {
            colSumm += arrT[i, j];
        }
        System.Console.Write($"{Math.Round((double)colSumm / arrT.GetLength(1), 2)}\t");
    }
}

int sizeM = InputNum("Введите количество строк: ");
int sizeN = InputNum("Введите количество столбцов: ");
int[,] arr = Create2DArray(sizeM, sizeN);
Fill2DArray(arr);
Print2DArray(arr);
System.Console.WriteLine();
AvgCols(arr);