using System;
namespace _24_10;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            System.Console.WriteLine("podaj dwie liczby\n");
            System.Console.Write("podaj a: ");
            double a = double.Parse(Console.ReadLine());
            System.Console.Write("podaj b: ");
            double b = double.Parse(Console.ReadLine());
            if(b==0)
            {
                throw new Exception("nie można dzielić przez 0");
            }
            double wyn = a/b;
            System.Console.Write($"wynik dzielenia:{a}/{b} = ");
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine($"{wyn:F3}");
            Console.ResetColor();
        }
        catch(DivideByZeroException)
        {
            ErrorColorChange("nie można dzielić przez zero");
        }
        catch(FormatException)
        {
            ErrorColorChange("błędny format danych");
        }
        catch(OverflowException)
        {
            ErrorColorChange($"Podana liczba jest błędna, podaj dane z zakresu <{double.MinValue};{double.MaxValue}>");
        }
        catch(Exception ex)
        {
            ErrorColorChange($"błąd:{ex.Message}");
        }


    }
    static void ErrorColorChange(string comment)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        System.Console.WriteLine($"\nBłąd: {comment}");
        Console.ResetColor();
    }
}
