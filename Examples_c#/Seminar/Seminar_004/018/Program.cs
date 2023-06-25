Console.WriteLine("Массив рандомных эл-тов от 0-1");

int InputSize(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

void ArrFill(int[] arr)
{
    for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(0, 2);
}

void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < arr.Length - 1) Console.Write(", ");
    }
    Console.WriteLine("]");
}

int size = InputSize("Введите размер массива: ");

int[] arr = new int[size];

ArrFill(arr);
PrintArr(arr);