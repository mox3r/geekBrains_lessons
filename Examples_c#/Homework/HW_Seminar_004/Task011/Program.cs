// На входе А и В - программа возводит А в степеь В;
int InputNum(string msg)
{
    System.Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}
void PowAB(int a, int b)
{
    System.Console.WriteLine($"{a} ** {b} = {Math.Pow(a, b)}");
}
int a = InputNum("Введите число А: ");
int b = InputNum("Введите число B: ");
PowAB(a, b);