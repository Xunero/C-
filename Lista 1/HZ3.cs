using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj liczbę do sprawdzenia: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsTriangular(number))
        {
            Console.WriteLine($"{number} jest liczbą trójkątną.");
        }
        else
        {
            Console.WriteLine($"{number} nie jest liczbą trójkątną.");
        }
    }

    static bool IsTriangular(int number)
    {
        if (number < 0)
            return false;

        int total = 0;
        int n = 1;
        while (total < number)
        {
            total += n;
            n++;
        }
        return total == number;
    }
}