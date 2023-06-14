// Ввести цифру, которая сверится с днём недели и определит выходной ли это
Console.Write("Заводи число: ");
int dayNum = int.Parse(Console.ReadLine()!);
if (dayNum < 1 || dayNum > 7)
{
    System.Console.WriteLine("В неделе всего 7 дней!! >_<");
}
else
{
    if (dayNum > 5)
    {
        System.Console.WriteLine("Это же выходной! Айда гулять!");
    }
    else
    {
        System.Console.WriteLine("Работай, негр, рано расслабляться...");
    }
}