Console.WriteLine("Ряд Фибоначи");

int InputNum(string msg)
{
    System.Console.Write("Введите число: ");
    return int.Parse(Console.ReadLine()!);
}

void Fibon(int num)
{
    int temp = 0, temp1 = 1, temp2 = 0;
    for (int i = 0; i <= num; i++)
    {
        System.Console.Write(temp + " ");
        temp2 = temp + temp1;
        temp = temp1;
        temp1 = temp2;
    }
 }

int num = InputNum("Введите число: ");
Fibon(num);
