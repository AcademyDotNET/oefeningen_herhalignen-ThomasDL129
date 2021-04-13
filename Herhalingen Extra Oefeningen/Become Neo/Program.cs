using System;

namespace Become_Neo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rangen = new Random();
            Console.ForegroundColor = ConsoleColor.Green;
            while (true)
            {
                //Genereer nieuw random teken:
                char teken = Convert.ToChar(rangen.Next(62, 400));
                //Zet teken op scherm
                Console.Write(teken);

                //Ietwat vertragen
                System.Threading.Thread.Sleep(10); //dit getal is in milliseconden. Speel er gerust mee.

                Console.ForegroundColor = (ConsoleColor)rangen.Next(0, 15);

                /*
                //Af en toe donker kleurtje
                if (rangen.Next(0, 3) == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }*/
            }
        }
    }
}
