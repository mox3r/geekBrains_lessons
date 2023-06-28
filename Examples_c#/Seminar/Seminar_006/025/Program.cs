Console.WriteLine("Принимает 3 числа. Может ли быть трекгольник с такими параметрами?");

int InputNum(string msg)
{
    System.Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

Boolean IsTreangle(int point1, int point2, int point3)
{
    if (point1 + point2 > point3 && point1 + point3 > point2 && point2 + point3 > point1) return true;
    return false;
}

int point1 = InputNum("Введите точку А: ");
int point2 = InputNum("Введите точку B: ");
int point3 = InputNum("Введите точку C: ");

System.Console.WriteLine($"Треугольник? {IsTreangle(point1, point2, point3)}");