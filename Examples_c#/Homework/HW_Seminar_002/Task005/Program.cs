//На входе трехзначное число - на выходе - вторая цифра
int number = new Random().Next(100, 1000);
System.Console.WriteLine($"Вторая цифра числа {number} равна {(number / 10) % 10}");