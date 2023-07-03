Console.WriteLine("Массив mxn. В четных позициях a[m,n] *= a[m,n].");

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
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(100);
        }
    }
}

void SortArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i += 2)
    {
        for (int j = 0; j < arr.GetLength(1); j += 2)
        {
            arr[i, j] *= arr[i, j];
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
SortArray(arr);
System.Console.WriteLine("Новый массив:");
PrintArray(arr);