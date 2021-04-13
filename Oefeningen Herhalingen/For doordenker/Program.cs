using System;

namespace For_doordenker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer een getal in:");
            int getal = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\n");

            for(int i = 1; i <= getal; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            for (int i = getal - 1; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
