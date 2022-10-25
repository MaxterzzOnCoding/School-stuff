using System;

namespace Geradenberechnung
{
    class Program
    {
        static void Main(string[] args)
        {
            int m1, b1, m2, b2, ;
            string gerade1, gerade2;
            double x, y;

            Console.WriteLine("Geradenberechnungen");
            Console.WriteLine("===================");

            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("1. Gerade: Bitte Steigung eingeben: ");
            gerade1 = Console.ReadLine();
            m1 = Convert.ToInt32(gerade1);
            Console.Write("1. Gerade: Bitte y-Achsenabschnitt eingeben: ");
            gerade1 = Console.ReadLine();
            b1 = Convert.ToInt32(gerade1);
            
            Console.WriteLine("");

            Console.Write("2. Gerade: Bitte Steigung eingeben: ");
            gerade2 = Console.ReadLine();
            m2 = Convert.ToInt32(gerade2);
            Console.Write("2. Gerade: Bitte y-Achsenabschnitt eingeben: ");
            gerade2 = Console.ReadLine();
            b2 = Convert.ToInt32(gerade2);

            Console.WriteLine("");

            Console.WriteLine("Ihre Geraden haben die folgenden Gleichungen:");
            if (b1 > 0 )
            {
                Console.WriteLine("y=" + m1 + "x + " + b1);
            }
            else if (b1 == 0)
            {
                Console.WriteLine("y=" + m1 + "x");
            }
            else if (b1 < 0)
            {
                Console.WriteLine("y=" + m1 + "x" + b1);
            }



            if (b2 > 0)
            {
                Console.WriteLine("y=" + m2 + "x + " + b2);
            }
            else if (b2 == 0)
            {
                Console.WriteLine("y=" + m2 + "x");
            }
            else if (b2 < 0)
            {
                Console.WriteLine("y=" + m2 + "x" + b2);
            }

            Console.WriteLine("");

            if (m1 == m2 && b1==b2)
            {
                Console.WriteLine("Die beiden Geraden sind identisch");
            }
            
            if (m1 == m2)
            {
                Console.WriteLine("Die beiden Geraden sind parallel");
            }
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());

            
        }
    }
}
