Console.WriteLine("Dec -> Bin");

int InputNum(string msg)
{
    System.Console.Write("Введите число: ");
    return int.Parse(Console.ReadLine()!);
}
int GetSize(int num)
{
    int size = 0;
    while (num != 0)
    {
        num /= 2;
        size++;
    }
    return size;
}
int[] CreateArray(int size)
{
    return new int[size];
}

void DecToBin(int num, int[] arr)
{
    for (int i = arr.Length - 1; i >= 0; i--)
    {
        arr[i] = num % 2;
        num /= 2;
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
    }
}


int num = InputNum("Введите число: ");
int[] arr = CreateArray(GetSize(num));
DecToBin(num, arr);
System.Console.Write($"Dec {num} = Bin ");
PrintArray(arr);