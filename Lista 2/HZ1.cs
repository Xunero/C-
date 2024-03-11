using System;
using System.Collections.Generic;

class Liczby
{
    public int Wartość { get; set; }
    public int WartośćBezwzględna { get; set; }
    public string Parzystość { get; set; }

    public Liczby(int wartość)
    {
        Wartość = wartość;
        WartośćBezwzględna = Math.Abs(wartość);
        Parzystość = wartość % 2 == 0 ? "parzysta" : "nieparzysta";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj ilość liczb do wygenerowania: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Podana liczba musi być dodatnia.");
            return;
        }

        HashSet<Liczby> kolekcja = new HashSet<Liczby>();
        Random rand = new Random();

        while (kolekcja.Count < n)
        {
            int wartość = rand.Next(-100, 101);
            Liczby liczba = new Liczby(wartość);
            kolekcja.Add(liczba);
        }

        Console.WriteLine("Wygenerowane liczby:");
        foreach (var liczba in kolekcja)
        {
            Console.WriteLine($"Wartość: {liczba.Wartość}, Wartość bezwzględna: {liczba.WartośćBezwzględna}, Parzystość: {liczba.Parzystość}");
        }
    }
}