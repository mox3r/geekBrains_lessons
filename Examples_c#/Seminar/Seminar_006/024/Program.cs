Console.WriteLine("Перевернуть массив.");

int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size)
{
    return new int[size];
}

void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100);
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

void PrintReverse(int[] arr)
{
    Console.Write("[");
    for (int i = arr.Length - 1; i >= 0; i--)
    {
        Console.Write(arr[i]);
        if (i > 0) Console.Write(", ");
        else Console.WriteLine("]");
    }
}

int size = InputNum("Введите размер массива: ");
int[] arr = CreateArray(size);

FillArray(arr);
PrintArray(arr);
PrintReverse(arr);