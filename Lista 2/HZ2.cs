using System;

enum SystemLiczbowy
{
    Dwójkowy,
    Szesnastkowy,
    Osemkowy,
    Piątkowy
}

class Liczba
{
    private string binarna;

    public Liczba(string binarna)
    {
        this.binarna = binarna;
    }

    public string Konwertuj(SystemLiczbowy system)
    {
        switch (system)
        {
            case SystemLiczbowy.Dwójkowy:
                return binarna;
            case SystemLiczbowy.Szesnastkowy:
                return KonwertujNaSzesnastkowy();
            case SystemLiczbowy.Osemkowy:
                return KonwertujNaOsemkowy();
            case SystemLiczbowy.Piątkowy:
                return KonwertujNaPiątkowy();
            default:
                throw new ArgumentException("Nieobsługiwany system liczbowy.");
        }
    }

    private string KonwertujNaSzesnastkowy()
    {
        int dziesiętny = Convert.ToInt32(binarna, 2);
        return Convert.ToString(dziesiętny, 16).ToUpper();
    }

    private string KonwertujNaOsemkowy()
    {
        int dziesiętny = Convert.ToInt32(binarna, 2);
        return Convert.ToString(dziesiętny, 8);
    }

    private string KonwertujNaPiątkowy()
    {
        int dziesiętny = Convert.ToInt32(binarna, 2);
        string piątkowy = "";

        while (dziesiętny > 0)
        {
            int reszta = dziesiętny % 5;
            piątkowy = reszta.ToString() + piątkowy;
            dziesiętny /= 5;
        }

        return piątkowy;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj liczbę binarną: ");
        string binarna = Console.ReadLine();

        Liczba liczba = new Liczba(binarna);

        Console.WriteLine($"Liczba szesnastkowa: {liczba.Konwertuj(SystemLiczbowy.Szesnastkowy)}");
        Console.WriteLine($"Liczba ósemkowa: {liczba.Konwertuj(SystemLiczbowy.Osemkowy)}");
        Console.WriteLine($"Liczba piątkowa: {liczba.Konwertuj(SystemLiczbowy.Piątkowy)}");
    }
}