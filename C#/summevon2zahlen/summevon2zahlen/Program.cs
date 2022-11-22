using System;

namespace summevon2zahlen
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl1;
            int zahl2;
            int summe = 0;
            string jnstring;
            char jn;

          

            do
            {
                Console.WriteLine("------------------------------");
                Console.Write("Bitte Zahl 1 eingeben: ");
                zahl1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Bitte Zahl 2 eingeben: ");
                zahl2 = Convert.ToInt32(Console.ReadLine());
                summe = zahl1 + zahl2;
                Console.WriteLine("Die Summe lautet: " + summe + "");
                Console.WriteLine("------------------------------");
                Console.Write("Wollen Sie das Programm nochmals starten? (J/N)    ");
                jnstring = Console.ReadLine();
                jn = Convert.ToChar(jnstring);
            } while (jn == 'j' || jn == 'J') ;




        }
    }
}
