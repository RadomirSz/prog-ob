using System;
namespace _31_10;

class Program
{
    static void Main(string[] args)
    {
        //Napisz program w C#, który wczytuje liczbę całkowitą od użytkownika i oblicza jej pierwiastek kwadratowy.
        //Jeśli liczba jest ujemna, program powinien zgłosić wyjątek ArgumentOutOfRangeException i wyświetlić odpowiedni komunikat. 
        //Jeśli użytkownik wprowadzi nieprawidłowe dane, program powinien zgłosić wyjątek FormatException i poprosić o ponowne wprowadzenie liczby. 
        //Program powinien działać w pętli, dopóki użytkownik nie wpisze q. Użyj instrukcji try-catch-finally do obsługi wyjątków.
    bool powtorz = true;
    do 
    {
        try
        {
            System.Console.WriteLine("Podaj liczbę do zpierwiastkowania lub \"q\" żeby zakończyć ");
            string input = Console.ReadLine();

            if(input == "q"){
                powtorz = false;
            }
            else if(Convert.ToInt64(input) < 0) throw new ArgumentOutOfRangeException(); 
            else
            {
                System.Console.WriteLine(Math.Sqrt(Convert.ToUInt64(input)));
            }

        }
        catch(ArgumentOutOfRangeException)
        {
            errorcolor("Liczba nie może być ujemna");
        }
        catch(OverflowException)
        {
            errorcolor("Zbyt duża liczba");
        }
        catch(FormatException)
        {
            errorcolor("Podano nieprawidłowe dane");
        }
        catch(Exception ex)
        {
            errorcolor($"{ex.Message}");
        }
        finally
        {
            System.Console.WriteLine("amongus nawiązanie");
        }
    }
    while(powtorz);
    }
    static void errorcolor(string komentarz)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        System.Console.WriteLine($"{komentarz}");
        Console.ResetColor();
    }



}
