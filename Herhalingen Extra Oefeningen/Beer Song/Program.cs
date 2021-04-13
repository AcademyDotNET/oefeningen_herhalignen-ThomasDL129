using System;

namespace Beer_Song
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "bottles of beer on the wall";
            string string2 = "bottles of beer";
            string string3 = "Take one down and pass it around,";

            int maxBottles = 99;
            for(int i = maxBottles; i >= 0; i--)
            {
                if (i == 0)
                {
                    Console.WriteLine($"\nNo more {string1}, no more {string2}.");
                    Console.WriteLine($"Go to the store and buy some more, 99 {string1}.");
                }
                else if (i == 1)
                {
                    Console.WriteLine($"\n{i} {string1}, {i} {string2}.");
                    Console.WriteLine($"Take it down and pass it around, no more {string1}.");
                }
                else if(i == 2)
                {
                    Console.WriteLine($"\n{i} {string1}, {i} {string2}.");
                    Console.WriteLine($"{string3} 1 bottle of beer on the wall.");
                }
                else
                {
                    Console.WriteLine($"\n{i} {string1}, {i} {string2}.");
                    Console.WriteLine($"{string3} {i} {string1}.");
                }
            }
        }
    }
}
