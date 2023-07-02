Console.WriteLine("Точка пересечения линейных функциий. Округление 2.");
Console.WriteLine("Вид функций: y = kx + b");
Console.WriteLine();

double InputNum(string msg)
{
    Console.Write(msg);
    return double.Parse(Console.ReadLine()!);
}

double[] CreateArray()
{
    return new double[2];
}

void FillArrayManual(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = InputNum($"Введите значение {i + 1}:");
    }
}
void CrossPoint(double[] arrk, double[] arrb)
{
    double x = (arrb[1] - arrb[0]) / (arrk[0] - arrk[1]);
    double y = arrk[0] * x + arrb[0];

    Console.Write($"Точка пересечения X = ({x};{y})");
}

double[] arrk = CreateArray();
double[] arrb = CreateArray();
Console.WriteLine("Введите значения k:");
FillArrayManual(arrk);
Console.WriteLine();
Console.WriteLine("Введите значения b:");
FillArrayManual(arrb);
Console.WriteLine();

if(arrk[0] == arrk[1]) Console.WriteLine("Это параллельные прямые. Точка пересечения отсутствует.");
else {
Console.WriteLine("Уравнения имеют вид:");
Console.WriteLine($"y = {arrk[0]}*x + {arrb[0]}");
Console.WriteLine($"y = {arrk[1]}*x + {arrb[1]}");
CrossPoint(arrk, arrb);
}