Console.WriteLine("Массив mxn. Найти сумму эл-то главной диагонали.");

int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

int[,] CreateArray(int sizeM, int sizeN)
{
    return new int[sizeM, sizeN];
}

void PrintArray(int[,] arr)
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

void FillArray(int[,] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(10);
        }
    }
}

int MainDiagonalSumm(int[,] arr)
{
    int mdsumm = 0;
    int temp = arr.GetLength(0);
    if (arr.GetLength(0)>arr.GetLength(1)) temp = arr.GetLength(1);
    for (int i = 0; i < temp; i++)
    {
        mdsumm += arr[i,i];
    }
    return mdsumm;
}

int sizeM = InputNum("Введите количество строк: ");
int sizeN = InputNum("Введите количество столбцов: ");

int[,] arr = CreateArray(sizeM, sizeN);

FillArray(arr);
PrintArray(arr);

System.Console.WriteLine($"Сумма эл-тов главной диагонали равна {MainDiagonalSumm(arr)}");