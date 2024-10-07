class KontoBankowe
{
    private decimal saldo; // Prywatne pole, które chronimy

    // Właściwość do odczytu i zapisu salda
    public decimal Saldo
    {
        get { return saldo; }
        private set // Tylko wewnętrznie możemy ustawić saldo
        {
            saldo = value;
        }
    }

    // Konstruktor
    public KontoBankowe(decimal poczatkoweSaldo)
    {
        if (poczatkoweSaldo >= 0)
        {
            Saldo = poczatkoweSaldo;
        }
        else
        {
            Saldo = 0; // Ustaw na 0, jeśli saldo początkowe jest ujemne
        }
    }

    // Metoda wpłacania pieniędzy
    public void Wplac(decimal kwota)
    {
        if (kwota > 0)
        {
            Saldo += kwota;  // Używamy prywatnego settera
        }
        else
        {
            Console.WriteLine("Kwota wpłaty musi być dodatnia!");
        }
    }

    // Metoda wypłacania pieniędzy
    public void Wyplac(decimal kwota)
    {
        if (kwota > 0 && kwota <= Saldo)
        {
            Saldo -= kwota; // Używamy prywatnego settera
        }
        else
        {
            Console.WriteLine("Nie można wypłacić tej kwoty!");
        }
    }
}

// Testowanie klasy
KontoBankowe konto = new KontoBankowe(1000);
Console.WriteLine($"Saldo: {konto.Saldo}");  // Wyświetli: 1000

konto.Wplac(500);  // Udzielamy wpłaty
Console.WriteLine($"Saldo po wpłacie: {konto.Saldo}");  // Wyświetli: 1500

konto.Wyplac(200);  // Wypłacamy 200
Console.WriteLine($"Saldo po wypłacie: {konto.Saldo}");  // Wyświetli: 1300

konto.Saldo = 5000; // Próba zmiany salda bezpośrednio
// Oczekiwany wynik: "Właściwość 'Saldo' jest tylko do odczytu!"