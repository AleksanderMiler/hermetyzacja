class Osoba
{
    public string imie;  // Publiczne pole
    public int wiek;     // Publiczne pole
}

// Testowanie klasy
Osoba osoba = new Osoba();
osoba.imie = "Jan";
osoba.wiek = 30;

// Użytkownik może ustawić wiek na wartość ujemną, co jest nieprawidłowe
osoba.wiek = -5;  // To powinno być zablokowane!
Console.WriteLine($"Imię: {osoba.imie}, Wiek: {osoba.wiek}");  // Wyświetli: Imię: Jan, Wiek: -5