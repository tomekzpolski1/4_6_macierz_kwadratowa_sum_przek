using System;

namespace ConsoleApp48
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Podaj n");
            //int n = int.Parse(Console.ReadLine());
            Random rand = new Random();
            int[,] tab1 = new int[5,5];
            int suma1 = 0;
            int suma2 = 0;
            for (int i = 0; i < tab1.GetLength(0); i++)
            {
                for (int j = 0; j < tab1.GetLength(1); j++)
                {
                    tab1[i, j] = rand.Next(1, 10);
                    Console.Write(tab1[i, j]+" ");
                }
                //Console.WriteLine("Element na 1-szej przekatnej to {0}", tab1[i, i]);
               suma1 = suma1 + tab1[i,i];
                //Console.WriteLine("Element na 2-giej przekatnej to {0}", tab1[i,4-i]);
               suma2 = suma2 + tab1[i, 4 - i];
                Console.WriteLine();
            }
            Console.WriteLine("Suma elementów na przekątnej to {0} (pierwsza przekątna) ",suma1);
            Console.WriteLine("Suma elementów na przekątnej to {0} (druga przekątna) ", suma2);
        }
    }
}
