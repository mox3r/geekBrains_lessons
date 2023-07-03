Console.WriteLine("Массив mxn. Найти эл-т по номеру.");

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

void SortArray(int[,] arr, int pos)
{
    if (pos > arr.GetLength(0) * arr.GetLength(1))
        System.Console.WriteLine("Массив мал, позиция большая");
    else
    {
        int pos1 = 0;
        while (pos - 1 > arr.GetLength(1))
        {
            pos -= arr.GetLength(1);
            pos1++;
        }
        System.Console.WriteLine($"{arr[pos1, pos - 1]}");
    }
}
int sizeM = InputNum("Введите количество строк: ");
int sizeN = InputNum("Введите количество столбцов: ");
int[,] arr = Create2DArray(sizeM, sizeN);
Fill2DArray(arr);
Print2DArray(arr);

int pos = InputNum("Введите позицию поиска: ");
SortArray(arr, pos);