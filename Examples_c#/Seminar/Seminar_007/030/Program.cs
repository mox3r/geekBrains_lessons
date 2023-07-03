Console.WriteLine("Массив mxn. Заполненный a[m,n] = m+n.");

int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

int[,] CreateArray(int sizeM, int sizeN)
{
    return new int[sizeM, sizeN];
}

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = i + j + 2;
        }
    }
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

int sizeM = InputNum("Введите количество строк: ");
int sizeN = InputNum("Введите количество столбцов: ");

int[,] arr = CreateArray(sizeM, sizeN);
FillArray(arr);
PrintArray(arr);