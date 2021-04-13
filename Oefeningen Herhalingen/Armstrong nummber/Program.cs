using System;

namespace Armstrong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer een nummer in:");

            string input = StringCleaner(Console.ReadLine());
            int lengte = input.Length;
            double totaal = 0;


            for (int i = 0; i < lengte; i++)
            {
                double getal = Char.GetNumericValue(input[i]);
                totaal += Math.Pow(getal, lengte);
            }

            if(totaal == Convert.ToDouble(input))
            {
                Console.WriteLine($"{input} is een Armstrong getal.");
            }
            else
            {
                Console.WriteLine($"{input} is geen Armstrong getal.");
            }
        }

        public static string StringCleaner(string input)
        {
            string clean = string.Empty;
            foreach(char element in input)
            {
                if (Char.GetNumericValue(element) != -1)
                {
                    clean += element.ToString();
                }
            }

            return clean;
        }
    }
}
