double Piph(double xa, double ya, double xb, double yb)
{
    double cLength = Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2)), 3);
    return cLength;
}

double NumCounter(string message)
{
    System.Console.Write(message);
    return double.Parse(Console.ReadLine()!);
}


double xa = NumCounter("Точка А. Введите координаты x: ");
double ya = NumCounter("Точка А. Введите координаты y: ");
double xb = NumCounter("Точка B. Введите координаты x: ");
double yb = NumCounter("Точка B. Введите координаты y: ");

double cLenth = Piph(xa, ya, xb, yb);

System.Console.WriteLine("Длина вектора между точками А и В равна " + cLenth);