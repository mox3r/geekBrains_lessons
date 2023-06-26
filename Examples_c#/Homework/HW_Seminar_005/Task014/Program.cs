Console.WriteLine("Массив с рандомными числами. Показать количество чётных чисел.");

int InputSize(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

int[] NewArray(int size)
{
    int[] arr = new int[size];
    return arr;
}

void FillAray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 1000);
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

int EvenParse(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    return count;
}

int size = InputSize("Введите размер массива: ");
int[] arr = NewArray(size);

FillAray(arr);
PrintArray(arr);

Console.WriteLine($"Количество четных чисел в массиве равно {EvenParse(arr)}");