System.Console.WriteLine("Массив вещественных чисел. Найти разницу между макс и мин значениями.");

int InputSize(string msg)
{
    System.Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

double[] NewArr(int size)
{
    double[] arr = new double[size];
    return arr;
}

void FillArray(double[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        int randInt = new Random().Next(-99, 100);
        double randDouble = Math.Round(new Random().NextDouble(), 2);
        arr[i] = (double)randInt + randDouble;
    }
}

void PrintArray(double[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < arr.Length - 1) System.Console.Write(", ");
        else System.Console.WriteLine("]");
    }
}

void PosMaxMinDef(double[] arr)
{
    int i = 0;
    int posMax = 0;
    int posMin = 0;
    for ( ; i < arr.Length; i++)
    {
        if (arr[i] > arr[posMax]) posMax = i;
        else if (arr[i] < arr[posMin]) posMin = i;
    }
    System.Console.WriteLine($"Максимум = {arr[posMax]}, минимум = {arr[posMin]};");
    System.Console.WriteLine($"Разница между максимальным и минимальным значениями равна: {arr[posMax] - arr[posMin]}");
}

int size = InputSize("Введите размер массива: ");
double[] arr = NewArr(size);

FillArray(arr);
PrintArray(arr);
PosMaxMinDef(arr);