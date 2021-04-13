using System;

namespace RNA_Transscriptie
{
    class Program
    {
        static void Main(string[] args)
        {
            string rna = "";
            string transRna = "";
            bool stop = false;

            Console.WriteLine("RNA Transcriptor. Geef de letters G, C, T of A een voor een in met een enter erna. Voer Q in om te stoppen.");

            while(!stop)
            {
                string input = Console.ReadLine().ToUpper();
                if(InputChecker(input))
                {
                    stop = true;
                }
                else
                {
                    switch (input)
                    {
                        case "G":
                            rna += "G";
                            transRna += "C";
                            break;
                        case "C":
                            rna += "C";
                            transRna += "G";
                            break;
                        case "T":
                            rna += "T";
                            transRna += "A";
                            break;
                        case "A":
                            rna += "A";
                            transRna += "U";
                            break;
                        default:
                            Console.WriteLine(">Foute invoer.");
                            break;
                    }
                }
            }

            Console.WriteLine($"\nRNA transscriptie:\n{rna}\n\n{transRna}");
        }

        public static bool InputChecker(string input)
        {
            if(input == "Q")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
