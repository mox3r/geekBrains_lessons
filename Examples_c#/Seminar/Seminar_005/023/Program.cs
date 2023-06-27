System.Console.WriteLine("Массив. Произведение arr[i] * arr[arr.Lenth - 1 - i].");

int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

int[] NewArr(int size)
{
    return new int[size];
}

void FillArray(int[] arr, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
        arr[i] = rnd.Next(min, max + 1);

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

void MultiPair(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        System.Console.Write($"{arr[i] * arr[arr.Length - i - 1]} ");
    }
    if (arr.Length % 2 == 1) System.Console.WriteLine(arr[arr.Length / 2]);
}

int size = InputNum("Введире размер массива: ");
int minVal = InputNum("Ведите минимальное значение эл-та: ");
int maxVal = InputNum("Ведите максимальное значение эл-та: ");

int[] arr = NewArr(size);

FillArray(arr, minVal, maxVal);
PrintArray(arr);
MultiPair(arr);