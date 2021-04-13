using System;

namespace For_doordenker_extra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer in hoe hoog de boom moet zijn:");
            int rows = Convert.ToInt32(Console.ReadLine());
            int width = rows * 2 - 1;

            for(int i = 0; i < rows; i++)
            {
                for (int j = 1; j <= width; j++)
                {
                    if(j <= width - rows - i || j > rows + i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
