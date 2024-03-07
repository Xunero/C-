class Program
{
    static void Main()
    {
        Console.WriteLine("Wprowadź liczbę do sprawdzenia:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsPrime(number))
        {
            Console.WriteLine($"{number} jest liczbą pierwszą.");
        }
        else
        {
            Console.WriteLine($"{number} nie jest liczbą pierwszą.");
        }
    }

    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}