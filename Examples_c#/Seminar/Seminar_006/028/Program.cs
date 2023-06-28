Console.WriteLine("Поэлементное копирование массива");

int InputNum(string msg)
{
    System.Console.Write(msg);
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
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1) System.Console.Write(", ");
        else System.Console.WriteLine("]");
    }
}

void CopyArray(int[] arr, int[] arr2)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr2[i] = arr[i];
    }
}

int size = InputNum("Введите размер массива: ");
int[] arr = CreateArray(size);
FillArray(arr);
System.Console.Write($"Исходный массив: ");
PrintArray(arr);
int[] arrcp = CreateArray(size);
CopyArray(arr, arrcp);
System.Console.Write($"Новый массив: ");
PrintArray(arrcp);