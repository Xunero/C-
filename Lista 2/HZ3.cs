using System;
using System.Collections.Generic;

class Klient
{
    public int NumerKonta { get; private set; }
    public int PIN { get; private set; }
    public decimal StanKonta { get; private set; }

    public Klient(int numerKonta, int pin, decimal stanKonta)
    {
        NumerKonta = numerKonta;
        PIN = pin;
        StanKonta = stanKonta;
    }

    public bool WeryfikujPIN(int pin)
    {
        return PIN == pin;
    }

    public void ZmieńPIN(int nowyPIN)
    {
        PIN = nowyPIN;
        Console.WriteLine("PIN został zmieniony.");
    }

    public void Wypłata(decimal kwota)
    {
        if (kwota > 0 && kwota <= StanKonta)
        {
            StanKonta -= kwota;
            Console.WriteLine($"Wypłacono {kwota:C}. Aktualny stan konta: {StanKonta:C}");
        }
        else
        {
            Console.WriteLine("Brak wystarczających środków na koncie.");
        }
    }

    public void Wpłata(decimal kwota)
    {
        if (kwota > 0)
        {
            StanKonta += kwota;
            Console.WriteLine($"Wpłacono {kwota:C}. Aktualny stan konta: {StanKonta:C}");
        }
        else
        {
            Console.WriteLine("Nieprawidłowa kwota.");
        }
    }

    public void SprawdźSaldo()
    {
        Console.WriteLine($"Aktualny stan konta: {StanKonta:C}");
    }
}

class Bankomat
{
    private List<Klient> klienci;
    private Dictionary<int, decimal> dostępneBanknoty;
    private decimal dostępneŚrodki;

    public Bankomat(List<Klient> klienci)
    {
        this.klienci = klienci;
        dostępneBanknoty = new Dictionary<int, decimal>();
        InicjujBanknoty();
        dostępneŚrodki = ObliczDostępneŚrodki();
    }

    private void InicjujBanknoty()
    {
        dostępneBanknoty.Add(200, 5);
        dostępneBanknoty.Add(100, 3);
        dostępneBanknoty.Add(50, 5);
        dostępneBanknoty.Add(20, 1);
        dostępneBanknoty.Add(10, 3);
    }

    public void ObsłużKlientów()
    {
        int liczbaKlientów = Math.Min(klienci.Count, 3); // Obsługujemy maksymalnie trzech klientów
        for (int i = 0; i < liczbaKlientów; i++)
        {
            Klient klient = klienci[i];
            Console.WriteLine($"\nObsługa klienta {i + 1}");
            ObsłużKlienta(klient);
        }
    }

    private void ObsłużKlienta(Klient klient)
    {
        Console.WriteLine($"Witaj, klient o numerze konta: {klient.NumerKonta}");
        Console.Write("Podaj PIN: ");
        int pin = int.Parse(Console.ReadLine());

        if (klient.WeryfikujPIN(pin))
        {
            Console.WriteLine("Logowanie udane.");
            WyświetlMenu(klient);
        }
        else
        {
            Console.WriteLine("Nieprawidłowy PIN.");
        }
    }

    private void WyświetlMenu(Klient klient)
    {
        while (true)
        {
            Console.WriteLine("\nMenu bankomatu:");
            Console.WriteLine("1. Wypłata");
            Console.WriteLine("2. Wpłata");
            Console.WriteLine("3. Sprawdź saldo");
            Console.WriteLine("4. Zmiana PINu");
            Console.WriteLine("5. Wyjście");

            Console.Write("Wybierz opcję: ");
            int opcja = int.Parse(Console.ReadLine());

            switch (opcja)
            {
                case 1:
                    Console.Write("Podaj kwotę do wypłaty: ");
                    decimal kwotaWypłaty = decimal.Parse(Console.ReadLine());
                    WypłaćKwotę(klient, kwotaWypłaty);
                    break;
                case 2:
                    Console.Write("Podaj kwotę do wpłaty: ");
                    decimal kwotaWpłaty = decimal.Parse(Console.ReadLine());
                    WpłaćKwotę(klient, kwotaWpłaty);
                    break;
                case 3:
                    klient.SprawdźSaldo();
                    break;
                case 4:
                    ZmieńPIN(klient);
                    break;
                case 5:
                    Console.WriteLine("Dziękujemy za skorzystanie z bankomatu. Do widzenia!");
                    return;
                default:
                    Console.WriteLine("Nieprawidłowa opcja.");
                    break;
            }
        }
    }

    private void WypłaćKwotę(Klient klient, decimal kwota)
    {
        if (kwota > dostępneŚrodki)
        {
            Console.WriteLine("Brak wystarczających środków w bankomacie.");
            return;
        }

        if (kwota > klient.StanKonta)
        {
            Console.WriteLine("Brak wystarczających środków na koncie.");
            return;
        }

        decimal maksymalnaWypłata = ObliczMaksymalnąWypłatę();
        if (kwota > maksymalnaWypłata)
        {
            Console.WriteLine($"Maksymalna możliwa wypłata to {maksymalnaWypłata:C}.");
            return;
        }

        WypłaćBanknotami(kwota, klient);
    }

    private decimal ObliczMaksymalnąWypłatę()
    {
        decimal maksymalnaWypłata = 0;
        foreach (var banknot in dostępneBanknoty)
        {
            int nominal = banknot.Key;
            int ilośćBanknotów = (int)banknot.Value;
            maksymalnaWypłata += nominal * ilośćBanknotów;
        }
        return maksymalnaWypłata;
    }

    private void WypłaćBanknotami(decimal kwota, Klient klient)
    {
        Dictionary<int, int> banknotyWypłaty = new Dictionary<int, int>();

        decimal reszta = kwota;
        foreach (var banknot in dostępneBanknoty)
        {
            int nominal = banknot.Key;
            int ilośćBanknotów = (int)banknot.Value;

            int ilośćWymaganychBanknotów = (int)(reszta / nominal);
            if (ilośćWymaganychBanknotów > ilośćBanknotów)
            {
                ilośćWymaganychBanknotów = ilośćBanknotów;
            }

            reszta -= ilośćWymaganychBanknotów * nominal;
            banknotyWypłaty.Add(nominal, ilośćWymaganychBanknotów);

            if (reszta == 0)
            {
                break;
            }
        }

        if (reszta == 0)
        {
            foreach (var banknot in banknotyWypłaty)
            {
                int nominal = banknot.Key;
                int ilośćBanknotów = banknot.Value;

                Console.WriteLine($"Wypłacono {ilośćBanknotów} banknotów o nominale {nominal} zł.");
                dostępneBanknoty[nominal] -= ilośćBanknotów;
            }

            klient.Wypłata(kwota);
        }
        else
        {
            Console.WriteLine("Brak odpowiednich banknotów do wypłaty.");
        }
    }

    private void WpłaćKwotę(Klient klient, decimal kwota)
    {
        if (kwota > 0)
        {
            klient.Wpłata(kwota);
            dostępneŚrodki += kwota;
        }
        else
        {
            Console.WriteLine("Nieprawidłowa kwota.");
        }
    }

    private void ZmieńPIN(Klient klient)
    {
        Console.Write("Podaj nowy PIN: ");
        int nowyPIN = int.Parse(Console.ReadLine());
        klient.ZmieńPIN(nowyPIN);
    }

    private decimal ObliczDostępneŚrodki()
    {
        decimal suma = 0;
        foreach (var banknot in dostępneBanknoty)
        {
            int nominal = banknot.Key;
            int ilośćBanknotów = (int)banknot.Value;
            suma += nominal * ilośćBanknotów;
        }
        return suma;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Klient> klienci = new List<Klient>
        {
            new Klient(123456, 1234, 1000),
            new Klient(654321, 5678, 2000),
            new Klient(987654, 9876, 1500)
        };

        Bankomat bankomat = new Bankomat(klienci);
        bankomat.ObsłużKlientów();
    }
}