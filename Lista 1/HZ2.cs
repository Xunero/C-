class Program
{
    static void Main()
    {
        Console.WriteLine("Wprowadź tekst do sprawdzenia:");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
        {
            Console.WriteLine($"{input} jest palindromem.");
        }
        else
        {
            Console.WriteLine($"{input} nie jest palindromem.");
        }
    }

    static bool IsPalindrome(string text)
    {
        text = text.ToLower(); // Zamiana na małe litery
        text = text.Replace(" ", ""); // Usunięcie spacji

        int left = 0;
        int right = text.Length - 1;

        while (left < right)
        {
            if (text[left] != text[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}