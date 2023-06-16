int InputQuater(string message)
{
    Console.Write(message);

    return int.Parse(Console.ReadLine()!);
}

void QuaterAnsw (int quat)
{
    switch (quat)
    {
        case (1):
        Console.WriteLine("(+x; +y) ");
        break;
        case (2):
        Console.WriteLine(" (+x; -y) ");
        break;
        case (3):
        Console.WriteLine(" (-x; -y) ");
        break;
        case (4):
        Console.WriteLine(" (-x; +y) ");
        break;
        default:
        System.Console.WriteLine("Одно либо оба значения должны быть равны нулю!");
        break;
    }
    
}
int q = InputQuater("Введите номер четверти: ");
QuaterAnsw(q);
