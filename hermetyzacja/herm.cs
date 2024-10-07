class Osoba
{
    private string imie;  // Prywatne pole
    private int wiek;     // Prywatne pole
    // Właściwość do odczytu i zapisu imienia
    public string Imie
    {
        get { return imie; }
        set { imie = value; }  // Możemy ustawić imię bez ograniczeń
    }
    // Właściwość do odczytu i zapisu wieku z kontrolą
    public int Wiek
    {
        get { return wiek; }
        set
        {
            if (value >= 0)   // Tylko wartości nieujemne
            {
                wiek = value;
            }
            else
            {
                Console.WriteLine("Wiek nie może być ujemny!"); // Komunikat o błędzie
            }
        }
    }
    // Konstruktor do ustawienia początkowych wartości
    public Osoba(string imie, int wiek)
    {
        Imie = imie;
        Wiek = wiek >= 0 ? wiek : 0;  // Ustawienie wieku na 0, jeśli jest ujemny
    }
}
// Testowanie klasy
Osoba osoba = new Osoba("Jan", 30);
Console.WriteLine($"Imię: {osoba.Imie}, Wiek: {osoba.Wiek}");  // Wyświetli: Imię: Jan, Wiek: 30
osoba.Wiek = -5;  // Próba ustawienia ujemnego wieku
// Oczekiwany wynik: "Wiek nie może być ujemny!"
Console.WriteLine($"Imię: {osoba.Imie}, Wiek: {osoba.Wiek}");  // Wiek pozostanie 30