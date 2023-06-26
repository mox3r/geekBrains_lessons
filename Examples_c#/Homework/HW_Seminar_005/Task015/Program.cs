Console.WriteLine("Сумма чисел на нечётных позициях в массиве.");

int InputSize(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

int[] NewArr(int size)
{
    int[] arr = new int[size];

    return arr;
}

void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-999, 1000);
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

int OddPosSumm(int[] arr)
{
    int summ = 0;

    for (int i = 1; i < arr.Length; i += 2) summ += arr[i];

    return summ;
}

int size = InputSize("Введите размер массива: ");
int[] arr = NewArr(size);

FillArray(arr);
PrintArray(arr);

Console.WriteLine("Сумма эл-тов на нечётных позициях равна: " + OddPosSumm(arr));