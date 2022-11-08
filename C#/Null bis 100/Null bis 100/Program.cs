using System;

namespace Null_bis_100
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
               if (i < 100)
                {
                    Console.Write("" + i + ", ");
                }
               else
                {
                    Console.Write("" + i + "");
                }
            }
        }
    }
}
