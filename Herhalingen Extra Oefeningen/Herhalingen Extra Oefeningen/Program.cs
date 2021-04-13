using System;

namespace Grootste_getal
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int z = 0;
            do
            {
                y = y + x;

                if (x > z)
                {
                    z = x;
                }

                Console.WriteLine("Voer gehele waarden in (32767=stop)");
                string instring = Console.ReadLine();
                x = Convert.ToInt32(instring);
                //....
            } while (x != 32767);
            Console.WriteLine($"Som is {y} en het grootste toegevoegde getal was {z}.");
        }
    }
}
