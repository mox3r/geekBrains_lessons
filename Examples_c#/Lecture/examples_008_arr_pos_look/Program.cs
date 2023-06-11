System.Console.WriteLine("Введите размер массива: ");
int arrLenght = int.Parse(Console.ReadLine()!);
int[] arr = new int [arrLenght];

System.Console.Write("Массив:");
for (int i = 0; i < arrLenght; i++)
{
    arr[i] = new Random().Next(0, 101);
    System.Console.Write(arr[i] + " ");
}

System.Console.WriteLine("\n");

System.Console.Write("Введите запрашиваемое число: ");
int find = int.Parse(Console.ReadLine());

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] == find)
    {
        System.Console.WriteLine($"Находится под позицией {i}");
        break;
    }
}

//Альтернативная запись.