namespace _8_05_12;

class Program
{
    static void Main(string[] args)
    {
        #region notatka
        /*
        //tworzenie listy
        List<int> ints = new List<int>();
        //inicjalizator kolekcji or some shit
        List<int> ints1 = new List<int>{1,2,1,3,4,5,10,-2,1};
        
        //dodawanie elementów do listy za pomocą metody add
        ints1.Add(1);
        ints1.Add(21);

        //usuwanie elementów z listy

        ints1.Remove(1);

        //wyswietlenie dlugości listy za pomocą właściwości Count
        System.Console.WriteLine(ints1.Count);
        foreach(int i in ints1) System.Console.WriteLine(i);
        */
        #endregion

        #region zadanie
        //utwórz listę liczb całkowitych i wypełnij ją losowymi wartościami z zakresu od 1 do 100.
	    //Napisz metodę, która przyjmuje jako parametr listę liczb i zwraca listę liczb, które są podzielne przez 3 lub 5.
	    //Wyświetl na konsoli listę liczb losowych i listę liczb podzielnych przez 3 lub 5.
        List<int> L1 = new List<int>{1,3,9,4,6,10,10,8,9,5,4,23,45,7,8,4};
        L1 = podmien(L1);
        foreach(int i in L1) System.Console.WriteLine(i);
        
        System.Console.WriteLine("druga: ");

        Random r = new Random();
        List<int> L = new List<int>();
        for (int i = 0; i < 10; i++)
        {
            L.Add(r.Next(1,101));
            System.Console.WriteLine(L[i]);
        }
        #endregion

    }
    static List<int> podmien(List<int> L)
    {
        List<int> L2 = new List<int>();
        foreach (int i in L) if(i%3==0 || i%5==0) L2.Add(i);
        return L2;
    }
}
