class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj współczynnik a:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj współczynnik b:");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj współczynnik c:");
        double c = Convert.ToDouble(Console.ReadLine());

        double delta = b * b - 4 * a * c;

        if (delta > 0)
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"Pierwiastki równania: x1 = {x1:f2}, x2 = {x2:f2}");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Równanie ma jeden pierwiastek: x = {x:f2}");
        }
        else
        {
            Console.WriteLine("Równanie nie ma pierwiastków rzeczywistych.");
        }
    }
}