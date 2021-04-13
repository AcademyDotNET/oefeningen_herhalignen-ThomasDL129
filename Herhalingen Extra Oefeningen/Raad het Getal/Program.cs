using System;

namespace Raad_het_Getal
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal;
            int poging = 0;
            int aantalPogingen = 0;
            int maxPogingen = 7;
            int ondergrens = 0;
            int bovengrens = 100;
            string pogingString;
            bool gevonden = false;
            Random rand = new Random();
            getal = rand.Next(0, 101);

            while (!gevonden && aantalPogingen != maxPogingen)
            {
                aantalPogingen++;
                Console.WriteLine($"Geef een getal tussen {ondergrens} en {bovengrens}");
                pogingString = Console.ReadLine();
                poging = int.Parse(pogingString);

                if(poging > ondergrens && poging < bovengrens)
                {
                    if (getal > poging)
                    {
                        Console.WriteLine("Het gezochte getal is groter, probeer opnieuw.");
                        ondergrens = poging;
                    }
                    else if (getal < poging)
                    {
                        Console.WriteLine("Het gezochte getal is kleiner, probeer opnieuw.");
                        bovengrens = poging;
                    }
                    else
                        gevonden = true;
                }
                else
                {
                    Console.WriteLine("Dat getal ligt niet in de opgegeven interval.");
                }
            }
            if (gevonden)
            {
                Console.WriteLine($"Gevonden! Het te zoeken getal was inderdaad {getal} je had er {aantalPogingen} pogingen voor nodig.");
            }
            else if (aantalPogingen == maxPogingen)
            {
                Console.WriteLine($"Helaas! Het te zoeken getal was {getal} je hebt het niet kunnen raden in de {maxPogingen} pogingen.");
            }
        }
    }
}
//
//                                                               
//  ________________________            ___________                                         ______________
// | generate random number | -------> /user input/ ------> < rand =? input >  ---Yes----> | print result |
//  ------------------------           ----------                   |                       --------------
//                                         ^                        No
//                                         |                        |
//                                         |                   ________________________
//                                         -------------------|increase amount of tries|
//                                                             ------------------------