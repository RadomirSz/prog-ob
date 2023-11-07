using System;
namespace _7_11;

class Program
{
    static void Main(string[] args)
    {
        int[] T = {1,2,3};
        System.Console.WriteLine(T[0] +" "+ T[T.Length - 1] );

        int[] T2 = new int[5];

        T2[1] = 1;
        T2[2] = 2;
        T2[3] = 3;
        T2[0] = 4;
        T2[4] = 5;

        foreach (int i in T2)
        {
        System.Console.WriteLine(i);    
        }

        int[] T3 = new int[5];
        for(int i = 0;i<5;i++)
        {
            T3[i] = Convert.ToInt32(Console.ReadLine());
        }
        int suma=0;
        foreach (int i in T3)
        {
         suma += i;   
        }
        System.Console.WriteLine(suma);

    }
}
