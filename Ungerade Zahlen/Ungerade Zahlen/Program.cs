using System;

namespace Ungerade_Zahlen
{
    class Program
    {
        static void Main(string[] args)
        {
            int obergrenze;
            int summe = 0;
           

            Console.WriteLine("Bitte geben Sie eine Obergrenze ein, bis zu der die Summe aller ungeraden Zahlen gebildet werden soll.");
            Console.Write("Obergrenze: ");
            obergrenze = Convert.ToInt32(Console.ReadLine());
            for (int zahl = 1; zahl <= obergrenze; zahl+=2)
            {
                summe = zahl + summe;
                Console.Write(zahl+" + ");
            }
            summe = summe + obergrenze ;
            Console.WriteLine("" + summe + "");
            Console.ReadKey();
        }
    }
}
