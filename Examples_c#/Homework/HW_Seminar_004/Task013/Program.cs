// принять числа в массив, вывести массив на экран;
// int[] ArrFilling(string msg)
// {
//     System.Console.WriteLine("Введите величину массива: ");
//     int size = int.Parse(Console.ReadLine()!);
//     int[] arr = new int[size];

//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write("Введите число: ");
//         arr[i] = int.Parse(Console.ReadLine()!);
//     }
//     return arr;
// }

int[] ArrAutoFilling(string msg)
{
    System.Console.WriteLine("Введите величину массива: ");
    int size = int.Parse(Console.ReadLine()!);
    int[] arr = new int[size];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}

void PrintArr(int[] arr)
{
    System.Console.Write("Ваш массив: [");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}");
        if (i < arr.Length - 1) System.Console.Write(", ");
        else System.Console.Write("]");
    }
}

System.Console.WriteLine("Заполнение массива и вывод его в консоль.");
int[] arr = ArrAutoFilling("Введите размер массива."); // можно и руками (перекомитить строки 41-42)
// int[] arr = ArrFilling("Введите размер массива.");
PrintArr(arr);