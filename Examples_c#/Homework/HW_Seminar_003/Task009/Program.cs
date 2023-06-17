double InputMsg(string message)
{
    System.Console.Write(message);
    return double.Parse(Console.ReadLine()!);
}
double DistVector(double xa, double ya, double za, double xb, double yb, double zb)
{
    double pow2 = Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2);
    System.Console.WriteLine(Math.Round(Math.Sqrt(pow2), 2));
    return 0;
}

double xa = InputMsg("Точка А. Введите х: ");
double ya = InputMsg("Точка А. Введите y: ");
double za = InputMsg("Точка А. Введите z: ");

double xb = InputMsg("Точка B. Введите х: ");
double yb = InputMsg("Точка B. Введите y: ");
double zb = InputMsg("Точка B. Введите z: ");

DistVector(xa, ya, za, xb, yb, zb);