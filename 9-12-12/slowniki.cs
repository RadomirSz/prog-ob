using System.Collections.Generic;
namespace _9_12_12;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int,string> people = new Dictionary<int,string>();
        people.Add(1,"zosia1");
        people.Add(2,"zosia2");
        people.Add(3,"zosia3");
        people.Add(4,"zosia4");
        foreach (var item in people)
        {
            System.Console.WriteLine($"{item.Value} , {item.Key}");
        }

        Dictionary<string,string> capital = new Dictionary<string,string>();

        capital = new Dictionary<string,string>
        {
            {"Polska", "Warszawa"},
            {"Niemcy", "Berlin"},
            {"Belgia", "Bruksela"},
            {"Czechy", "Praga"}
        };

        foreach (var item in capital)
        {
            System.Console.WriteLine($"{item.Key}, {item.Value}");
        }


        Dictionary<string,string> phones = new Dictionary<string,string>();
        phones.Add("3465098906","Tomasz");
        phones.Add("3123489090","Tom12asz");
        phones.Add("3461234980","To123masz");
        phones.Add("3461234890","Tom1234asz");

        foreach (var item in phones)
        {
            System.Console.WriteLine("nr tele: {0} , imie: {1}", item.Key , item.Value);
        }

        

    }
}
