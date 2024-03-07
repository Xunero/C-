class Program
{
    static void Main()
    {
        // Wprowadzenie stopnia pierwiastka (n) i liczby (K) przez użytkownika
        Console.Write("Podaj stopień pierwiastka (n): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Podaj liczbę (K): ");
        double K = double.Parse(Console.ReadLine());

        // Sprawdzenie, czy stopień pierwiastka n jest większy niż 0
        if (n <= 0)
        {
            Console.WriteLine("Stopień pierwiastka musi być liczbą dodatnią.");
            return;
        }

        // Obliczenie pierwiastka n-tego stopnia z liczby K
        double result = Math.Pow(K, 1.0 / n);

        // Wyświetlenie wyniku
        Console.WriteLine($"Pierwiastek {n}-tego stopnia z liczby {K} wynosi: {result}");
    }
}