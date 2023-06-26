Console.WriteLine("Массив заполненный [-9;9]. Показать сумму отрицательных и положительных значений.");

int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

int[] NewArr(int size)
{
    return new int[size];
}

void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-9, 10);
    }
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < arr.Length - 1) Console.Write(", ");
        else Console.WriteLine("]");
    }
}

void SumMinMax(int[] arr)
{
    int min = 0;
    int max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) max += arr[i];
        else if (arr[i] < 0) min += arr[i];
    }

    Console.WriteLine($"Сумма положительных эл-тов: {max}");
    Console.WriteLine($"Сумма отрицательных эл-тов: {min}");
}

int size = InputNum("Введите длину массива: ");
int[] arr = NewArr(size);
FillArray(arr);
PrintArray(arr);
SumMinMax(arr);