Console.WriteLine("Юзер вводит числа. Cколько положительных?");

int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size)
{
    return new int[size];
}

int FillNCountArrayManual(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = InputNum($"Введите {i + 1}-е число: ");
        if (arr[i] > 0) count++;
    }
    return count;
}

int size = InputNum("Введите размер массива: ");
int[] arr = CreateArray(size);

Console.WriteLine($"Вы введи {FillNCountArrayManual(arr)} положительных чисел.");