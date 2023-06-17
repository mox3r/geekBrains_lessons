// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int InsNum(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
void PalindromeTry(int num)
{
    if (num < 0) System.Console.WriteLine("Число не является палиндромом!");
    else if (num < 10) System.Console.WriteLine("Число является палиндромом!");
    else
    {
        int count = 0;
        int m = 1;
        int temp = num;
        while (temp / m != 0)
        {
            count++;
            m *= 10;
        }

        if (count % 2 == 0)
        {
            System.Console.WriteLine("Число не является палиндромом!");
        }
        else
        {
            int[] arr = new int[count];
            for (int i = 0; i < count; i++)
            {
                m /= 10;
                arr[i] = (num / m) % 10;

            }

            for (int i = 0; i < arr.Length / 2; i++)
            {
                if (arr[i] == arr[count - 1])
                {
                    count--;
                }
                else
                {
                    System.Console.WriteLine("Число не является палиндромом!");
                    break;
                }
                if (i == arr.Length / 2 - 1) System.Console.WriteLine("Число является палиндромом!");
            }
        }
    }
}

System.Console.WriteLine("Проверка на палиндром!");
int num = InsNum("Введите число: ");
PalindromeTry(num);