using System;
using System.Runtime.InteropServices;

namespace _19._09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // komentarz jednoliniowy
            /*
             wielo
            liniowy komentarz
             */
            Console.WriteLine("cześć");
            Console.Write("bu: ");
            Console.Write("cześć");
            Console.Clear();


            /*
             int 16,32,64
             byte 0 do 255
             sbyte -128 do 127
             short -32768 do 32767
             int  - 2 147 483 648 do 2 147 483 648
             */
            int i; // deklaracja zmiennej
            int i1 = 10; // deklracja z jednoczesną inicjalizacją zmiennej

            Console.WriteLine("zmienna i1: " + i1);

            System.Int32 i2 = 20;

            Console.WriteLine($"i1: {i1}, i2: {i2}");

            byte a = 100;
            sbyte b = -100;
            short c = -20000;
                        
            // dokończyć uint i pozostałe typy
            Console.ReadKey();

        }
    }
}
