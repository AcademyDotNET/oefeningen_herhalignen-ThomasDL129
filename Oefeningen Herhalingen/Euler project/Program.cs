using System;

namespace Euler_project
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 1000;
            int total = 0;

            for (int i = 0; i <= max; i++)
            {
                if(i % 3 == 0)
                {
                    total += i;
                }
                else if(i % 5 == 0)
                {
                    total += i;
                }
            }

            Console.WriteLine(total);
        }
    }
}
