// See https://aka.ms/new-console-template for more information
using System;
internal class Program
{
    public static void Main(string[] args)
    {
        // main metod programın başladığı yer ve bittiği yer 
        // program buradan ayağa kalkar
        // public her yerden ulaşıla bilir 
        // static nesne oluşturmadan ulaşıla bilir
        // void geriye bir şey dönmez
        Console.WriteLine("Merhaba Furkan"); // üste tanımladığımız için system artık buraya yazılmasa da olur soluk olduğu burada kullanılmadığı anlamına gelir
        Console.WriteLine("Adınızı Giriniz:");
        string? name = Console.ReadLine();
        Console.WriteLine("Soyadınızı Giriniz:");
        string? surName = Console.ReadLine();

        Console.WriteLine("Merhaba  " + name + " " + surName);
    }
}