System.Console.Write("Введите размер массива: ");
int arrLenght = int.Parse(Console.ReadLine()!);
int[] arr = new int[arrLenght];

FillArray();
System.Console.Write("Массив:");
PrintArray();

System.Console.WriteLine("\n");

System.Console.Write("Введите запрашиваемое число: ");

int find = int.Parse(Console.ReadLine()!);
int pos = -1;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] == find)
    {
        pos = i;
       
        break;
    }
}
 System.Console.WriteLine($"Находится под позицией: {pos}");

void FillArray()
{
    for (int i = 0; i < arrLenght; i++)
    {
        arr[i] = new Random().Next(0, 101);
    }
}

void PrintArray()
{
    for (int i = 0; i < arrLenght; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
}
