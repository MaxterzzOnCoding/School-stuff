using System;

namespace wurfel
{
    class Program
    {
        static void Main(string[] args)
        {
            Random zufgen = new Random();
            int zahl;
            zahl = 0;
            int zahl1 = 0;
   ;

            Console.WriteLine("Würfelspiel");
            Console.WriteLine("============");

            do
            {
             zahl = zufgen.Next(1, 7);
                Console.WriteLine("gewürfelte Zahl:"+zahl);
                zahl1 = zahl1 + zahl ;
            
            } while (zahl < 6);
            zahl1 = zahl1 - 6;
            Console.WriteLine("Summe:"+zahl1);
            Console.ReadKey();
        }
    }
}
