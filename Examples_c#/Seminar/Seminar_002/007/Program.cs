//Удалить вторую цифру из трёхзначного числа
System.Console.Write("Случайное число: ");
int num = new Random().Next(100, 1000);
System.Console.WriteLine(num);

System.Console.WriteLine($"Новое число равняется: {Alg(num)}");

int Alg (int num)
{
int num1 = num / 100;
int num2 = num % 10;
int num3 = num1 * 10 + num2;
return num3;
}
