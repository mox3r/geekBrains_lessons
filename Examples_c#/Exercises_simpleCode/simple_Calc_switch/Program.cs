Console.WriteLine("Простейший калькулятор.");

int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

int num1 = InputNum("Введите число а: ");
int num2 = InputNum("Введите число b: ");

Console.WriteLine(
    "Выберите действие: \n" +
    "1. a + b \n" +
    "2. a - b \n" +
    "3. a * b \n" +
    "4. a / b \n"
    );

int sw = InputNum("Ваш выбор: ");

switch (sw)
{
    case (1):
        Console.WriteLine($"a + b = {num1 + num2}");
        break;
    case (2):
        Console.WriteLine($"a - b = {num1 - num2}");
        break;
    case (3):
        Console.WriteLine($"a * b = {num1 * num2}");
        break;
    case (4):
        if (num2 == 0) Console.WriteLine("Ну куда ты на ноль делишь то??");
        else Console.WriteLine($"a / b = {num1 / num2}");
        break;
    default:
        Console.WriteLine("Я хз че ты хочешь!");
        break;
}