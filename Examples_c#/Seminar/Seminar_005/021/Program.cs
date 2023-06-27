Console.WriteLine("Массив, рандомная длина, значения. Узнать есть ли там искомое число.");

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

bool IsNum(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] == num)
            return true;

    return false;
}

int size = InputNum("Введите размер массива: ");
int minVal = InputNum("Введите минимальное значение массива: ");
int maxVal = InputNum("Введите максимальное значение массива: ");
int num = InputNum("Введите искомое число: ");
int[] arr = NewArr(size);
FillArray(arr, minVal, maxVal);
PrintArray(arr);
Console.WriteLine($"Найдено ? {IsNum(arr, num)}");