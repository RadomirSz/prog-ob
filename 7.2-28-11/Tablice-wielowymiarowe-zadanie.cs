using System.Threading;
using System;
namespace _7._2_28_11;

class Program
{
    static void Main(string[] args)
    {
        #region code
        int a = WczytajLiczbe();
        int b = WczytajLiczbe();

        int[,] ints = UtworzTablice(a,b);
        WypelnijTablice(ints);
        WyswietlTablice(ints);
        System.Console.WriteLine(ObliczSume(ints));
        
        #endregion

    }
    #region funkcje
    static int WczytajLiczbe()
    {
        while(true){
            System.Console.WriteLine("Podaj liczbę dodatnią całkowitą lub \"q\" jeżeli chcesz zakończyć dzialanie programu.");
            string? liczba = Console.ReadLine();
            if(liczba == "q")
            {
                System.Console.WriteLine("Zakończono program!"); 
                Thread.Sleep(1000); 
                Environment.Exit(0);
            }
            try
            {
                int a = int.Parse(liczba);
                if(a < 0)
                {
                    throw new Exception("Podaj liczbę większą od 0.");
                }
                return a;
            }
            catch (System.Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
        }
    }

    static int[,] UtworzTablice(int n, int m)
    {
        int[,] T = new int[n,m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                T[i,j] = WczytajLiczbe();
            }
        }
        System.Console.WriteLine("Pomyślnie utworzono Tablicę");
        return T;
    }

    static int[,] WypelnijTablice(int[,] T)
    {
        Random r = new Random();
        System.Console.WriteLine("Podaj minimalną liczbę losową.");
        int a = WczytajLiczbe();
        System.Console.WriteLine("Podaj maksymalną liczbę losową.");
        int b = WczytajLiczbe();

        for (int i = 0; i < T.GetLength(0); i++)
        {
            for (int j = 0; j < T.GetLength(1); j++)
            {
                T[i,j] = r.Next(a,b+1);
            }
        }
        System.Console.WriteLine("Pomyślnie wypełniono Tablicę losowymi liczbami");
        return T;
    }

    static void WyswietlTablice(int[,] T)
    {
        for (int i = 0; i < T.GetLength(0); i++)
        {
            for (int j = 0; j < T.GetLength(1); j++)
            {
                System.Console.Write(T[i,j] + " ");
            }
            System.Console.WriteLine();
        }
    }
    static int ObliczSume(int[,] T)
    {
        int suma = 0;
        for (int i = 0; i < T.GetLength(0); i++)
        {
            for (int j = 0; j < T.GetLength(1); j++)
            {
                if(i==j) suma += T[i,j];
            }
        }
        return suma;
    }
    #endregion
}



grupa 1
Napisz program, który:

Definiuje funkcję UtworzTabliceLiczb(int n), która przyjmuje jako parametr liczbę całkowitą n i zwraca tablicę jednowymiarową o długości n, wypełnioną liczbami z zakresu od 1 do 10, które podaje użytkownik z klawiatury
Definiuje funkcję ObliczPole(int a), która przyjmuje jako parametr liczbę całkowitą a i zwraca wartość pola kwadratu o boku a. Wzór na pole kwadratu to:
P=a2

Definiuje funkcję ObliczObwod(int a), która przyjmuje jako parametr liczbę całkowitą a i zwraca wartość obwodu kwadratu o boku a. Wzór na obwód kwadratu to:
O=4a

W funkcji Main:
Deklaruje zmienną n i przypisuje jej wartość 5.
Wywołuje funkcję UtworzTabliceLiczb(n) i przypisuje jej wynik do zmiennej tablica.
Wyświetla na ekranie zawartość tablicy tablica.
Dla każdego elementu tablicy tablica:
Wywołuje funkcję ObliczPole i przypisuje jej wynik do zmiennej pole.
Wywołuje funkcję ObliczObwod i przypisuje jej wynik do zmiennej obwod.
Wyświetla na ekranie informację o polu i obwodzie kwadratu o boku równym danemu elementowi tablicy.
Napisz funkcję, która umożliwia podanie w parametrze indeksu tablicy a następnie zwróci ona wynik pola i obwodu kwadratu

https://drive.google.com/drive/folders/1iIAKNdDHyyc1lk41IHYXw6kSbIhS5zFd?usp=sharing





#########################################################################################################
namespace csharp;

class Program
{
    static void Main(string[] args)
    {
        int a = GetIntFromUser();
        int[] A = UtworzTabliceLiczb(a);
        displayarr(A);
    }
    static int[] UtworzTabliceLiczb(int n)
    {
        int[] T = new int[n];

        for(int i = 0 ; i < n ; i++)
        {
            T[i] = GetIntFromUser();
        }
        return T;
    }
    static int GetIntFromUser()
    {
        System.Console.WriteLine("daj liczbę całkowitą");
        while(true)
        {
            if(int.TryParse(Console.ReadLine(), out int number) && number > 0 && number < 11)
            {
                return number;
            }
            System.Console.WriteLine("Niepoprawna liczba!");
        }
    }
    static void displayarr(int[] T)
    {
        System.Console.WriteLine("twoja tablica: ");
        foreach (int i in T) System.Console.WriteLine(i);
    }
    ststic int ObliczPole(int a)
    {
        a = a*a;
        System.Console.WriteLine("pole kwadratu o boku a to: "+ a + "cm²");
    }
}