Console.WriteLine("Массив вещественных чисел. Найти разницу между макс и мин значениями.");

int InputSize(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

double[] NewArr(int size)
{
    double[] arr = new double[size];
    return arr;
}

void FillArray(double[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        int randInt = rnd.Next(-99, 100);
        double randDouble = Math.Round(rnd.NextDouble(), 2);
        arr[i] = (double)randInt + randDouble;
    }
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < arr.Length - 1) Console.Write(", ");
        else Console.WriteLine("]");
    }
}

void PosMaxMinDef(double[] arr)
{
    int posMax = 0;
    int posMin = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > arr[posMax]) posMax = i;
        else if (arr[i] < arr[posMin]) posMin = i;
    }

    Console.WriteLine($"Максимум = {arr[posMax]}, минимум = {arr[posMin]};");
    Console.WriteLine($"Разница между максимальным и минимальным значениями равна: {arr[posMax] - arr[posMin]}");
}

int size = InputSize("Введите размер массива: ");
double[] arr = NewArr(size);

FillArray(arr);
PrintArray(arr);
PosMaxMinDef(arr);