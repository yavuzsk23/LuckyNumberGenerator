using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int luckyNumber = rnd.Next(1, 100); 
        Console.WriteLine($"you luck number {luckyNumber}");
        Console.ReadKey();
    }
}
