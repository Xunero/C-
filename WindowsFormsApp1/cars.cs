namespace CarDealershipApp
{
    // Abstrakcyjna klasa bazowa reprezentująca samochód
    public abstract class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        // Metoda abstrakcyjna do wyświetlania informacji o pojeździe
        public abstract string DisplayInfo();
    }

    // Klasy pochodne reprezentujące różne typy samochodów
    public class SportCar : Car
    {
        public int TopSpeed { get; set; }

        // Implementacja metody do wyświetlania informacji o samochodzie sportowym
        public override string DisplayInfo()
        {
            return $"Sport Car: {Brand} {Model}, Year: {Year}, Top Speed: {TopSpeed} km/h";
        }
    }

    public class FamilyCar : Car
    {
        public int NumberOfSeats { get; set; }

        // Implementacja metody do wyświetlania informacji o samochodzie rodzinym
        public override string DisplayInfo()
        {
            return $"Family Car: {Brand} {Model}, Year: {Year}, Seats: {NumberOfSeats}";
        }
    }

    public class OffroadCar : Car
    {
        public bool FourWheelDrive { get; set; }

        // Implementacja metody do wyświetlania informacji o samochodzie terenowym
        public override string DisplayInfo()
        {
            return $"Off-road Car: {Brand} {Model}, Year: {Year}, 4WD: {(FourWheelDrive ? "Yes" : "No")}";
        }
    }
}