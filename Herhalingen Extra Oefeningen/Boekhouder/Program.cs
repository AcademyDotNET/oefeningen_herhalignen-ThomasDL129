using System;

namespace Boekhouder
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int posTotal = 0;
            int negTotal = 0;
            double numberAmount = 0.0;

            do
            {
                int input = Convert.ToInt32(Console.ReadLine());
                numberAmount++;
                if(input >= 0)
                {
                    posTotal += input;
                    total += input;
                }
                else
                {
                    negTotal += input;
                    total += input;
                }
                Console.WriteLine($"Total = {total} \tAverage = {Math.Round(total/numberAmount, 2, MidpointRounding.AwayFromZero)} \tTotal positive = {posTotal} \tTotal negative = {negTotal}");
            } while (true);
        }
    }
}
