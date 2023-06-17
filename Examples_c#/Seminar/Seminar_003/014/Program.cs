int CounterParse(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int Pow2(int counter)
{
    for (int i = 1; i <= counter; i++)
    {
        System.Console.Write(Math.Pow(i,2));
        if (i < counter)
        System.Console.Write(", ");
    }
    return 0;
}

int counter = CounterParse("Введите длину степенного ряда: ");
Pow2(counter);