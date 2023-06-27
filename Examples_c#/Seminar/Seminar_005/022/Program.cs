Console.WriteLine("Рандомный массив. Найти колличество эл-тов на отрезке [10,99]");

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

int LineCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] >= 10 && arr[i] <= 99)
            count++;
    return count;
}

int size = InputNum("Введите размер массива: ");
int minVal = InputNum("Введите минимальный эл-т: ");
int maxVal = InputNum("Введите максимальный эл-т: ");
int[] arr = NewArr(size);

FillArray(arr,  minVal, maxVal);
PrintArray(arr);
System.Console.WriteLine($"Число эл-тов на отрезке [10,99] равно {LineCount(arr)}");