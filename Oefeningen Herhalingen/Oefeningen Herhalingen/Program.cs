using System;

namespace Oefeningen_Herhalingen
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 10; i++)
            {
                for(int j = 1; j <= 10; j++)
                {
                    Console.SetCursorPosition((j - 1) * 10, i - 1);
                    Console.Write($"{j}x{i}");
                    Console.SetCursorPosition(((j - 1) * 10 + 4), i - 1);
                    Console.Write($" = {i * j}");
                }
            }
        }
    }
}
