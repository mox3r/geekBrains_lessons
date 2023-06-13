double RURToUSD = 82.64;
double BYNToUSD = 2.9495;
Console.Write("Введите колличество USD: ");    
double USD = double.Parse(Console.ReadLine()!);
Console.WriteLine($"{USD} USD = " + USD * RURToUSD + " RUR");
System.Console.WriteLine($"{USD} USD = " + USD * BYNToUSD + " BYN");