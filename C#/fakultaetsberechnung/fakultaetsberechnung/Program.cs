using System;

namespace fakultaetsberechnung
{
    class Program
    {
        static void Main(string[] args)
        {
            int eingabe;
            int faku = 1;

            Console.WriteLine("Fakultätsberechnung");
            Console.WriteLine("");
            Console.Write("Natürliche Zahl eingeben: ");
            eingabe = Convert.ToInt32(Console.ReadLine());

            for (int fak = 1; fak <= eingabe; fak++)
            {
                faku = fak * faku;
            }
            Console.WriteLine(""+eingabe+"! = "+faku);
        }
    }
}
