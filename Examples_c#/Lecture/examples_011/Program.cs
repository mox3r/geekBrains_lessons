int[,] table = new int[3,5];

for (int rows = 0; rows < table.GetLength(0); rows++)
{
    for (int cols = 0; cols < table.GetLength(1); cols++)
    {
        table[rows,cols] = new Random().Next(10);
    }
}

for (int rows = 0; rows < table.GetLength(0); rows++)
{
    for (int cols = 0; cols < table.GetLength(1); cols++)
    {
        Console.Write($"{table[rows,cols]} ");
    }
    System.Console.WriteLine();
}