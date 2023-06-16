int[] InsSomeNum()
{
    Console.Write("Введите колличество чисел: ");
    int size = int.Parse(Console.ReadLine()!);
    int[] nums = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1}-е число: ");
        nums[i] = int.Parse(Console.ReadLine()!);
    }
    return nums;
}
int PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length;)
    {
        Console.Write($"{arr[i]}");
        i++;
        if (i < arr.Length)
        {
            Console.Write(", ");
        }
    }
    return 0;
}
int[] array = InsSomeNum();
PrintArray(array);
