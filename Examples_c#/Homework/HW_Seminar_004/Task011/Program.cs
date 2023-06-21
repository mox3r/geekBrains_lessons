// На входе А и В - программа возводит А в степеь В;
int InputNum(string msg)
{
    System.Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}
void PowAB(int a, int b)
{
    if (b >= 0) System.Console.WriteLine($"{a} ** {b} = {Math.Pow(a, b)}");
    else System.Console.WriteLine("Не стоит возводить в отрицательную степень!");
}
System.Console.WriteLine("Число А в степени В");
int a = InputNum("Введите число А: ");
int b = InputNum("Введите число B: ");
PowAB(a, b);