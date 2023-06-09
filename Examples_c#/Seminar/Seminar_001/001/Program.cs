/* Программа возведения целого числа в квадрат */
Console.Write("Введите целое число: ");
string num1 = Console.ReadLine();
int num = int.Parse(num1);
Console.Write($"Квадрат числа {num} равен: {num*num}");