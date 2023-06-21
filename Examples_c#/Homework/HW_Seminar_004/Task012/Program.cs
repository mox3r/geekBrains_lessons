// Принимает на вход число и возвращает сумму цифр в нём;

int InputNum(string msg)
{
    System.Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

int ArrSort(int num)
{
    int count = 0;
    int m = 1;
    int temp = num;
    while (temp / m != 0)
    {
        count++;
        m *= 10;
    }


    int[] arr = new int[count];
    for (int i = 0; i < count; i++)
    {
        m /= 10;
        arr[i] = (num / m) % 10;

    }

    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        result += arr[i];
    }

    return result;
}

System.Console.WriteLine("Сумма цифр в числе.");
int num = InputNum("Введите число: ");
int result = ArrSort(num);
System.Console.WriteLine(result);