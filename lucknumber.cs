using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Şanslı Sayı Üretici ===");
        
        Random rnd = new Random();
        int sansliSayi = rnd.Next(1, 100); // 1 ile 99 arasında rastgele sayı

        Console.WriteLine($"Şanslı sayınız: {sansliSayi}");
        
        Console.WriteLine("\nÇıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}
