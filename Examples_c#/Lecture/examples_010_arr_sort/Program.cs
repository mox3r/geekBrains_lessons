int[] arr = { 13, 52, 34, 7, 3, 89, 3, 24, 9, 4, 6, 7, 8, 5, 5 };

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1) System.Console.Write(", ");
        else System.Console.Write(" ");
    }
}

void arrSort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int minPos = i;

        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[minPos]) minPos = j;
        }

        int temp = arr[i];
        arr[i] = arr[minPos];
        arr[minPos] = temp;
    }
}

PrintArray(arr);
System.Console.WriteLine("\n");
arrSort(arr);
PrintArray(arr);
