using System.Diagnostics;

bool Check(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] > array[i + 1])
            return false;
    }
    return true;
}

bool show = false;

int size = 1000000;
int max = 2000000;

int[] arr1 = new int[size];

for (int i = 0; i < size; i++)
    arr1[i] = Random.Shared.Next(max);

if (show) Console.WriteLine($"[{String.Join(", ", arr1)}]");
if (show) Console.WriteLine(Check(arr1));

;
int[] arr2 = new int[size];


Array.Copy(arr1, arr2, size);

Stopwatch sw = new Stopwatch();
sw.Start();

for (int i = 0; i < size - 1; i++)
{
    for (int k = 0; k < size - 1 - i; k++)
    {
        if (arr1[k] > arr1[k + 1])
        {
            int temp = arr1[k];
            arr1[k] = arr1[k + 1];
            arr1[k + 1] = temp;
        }
    }
}
sw.Stop();

Console.WriteLine($"arr1 - {Check(arr1)} {sw.ElapsedMilliseconds} ms");
if (show) Console.WriteLine($"[arr1: {String.Join(',', arr1)}]");
Console.WriteLine();
if (show) Console.WriteLine($"[arr2: {String.Join(',', arr2)}]");

sw.Reset();
sw.Start();

for (int i = 0; i < size - 1; i++)
{
    for (int k = 0; k < size - 1; k++)
    {
        if (arr2[k] > arr2[k + 1])
        {
            int temp = arr2[k];
            arr2[k] = arr2[k + 1];
            arr2[k + 1] = temp;
        }
    }
}
sw.Stop();
Console.WriteLine($"arr2 - {Check(arr2)} {sw.ElapsedMilliseconds} ms");

if (show) Console.WriteLine($"[{String.Join(',', arr2)}]");

