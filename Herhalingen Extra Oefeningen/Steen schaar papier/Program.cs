using System;

//TO DO: resultscreen



namespace Steen_schaar_papier
{
    class Program
    {
        public enum Choice { Steen, Papier, Schaar }
        public enum WinState { Verloren, Gewonnen, Gelijkspel }
        static void Main(string[] args)
        {

            Gameloop();
            
        }

        public static void Gameloop()
        {
            int score = 0;
            int scoreAI = 0;
            int maxScore = 10;
            Random rand = new Random();

            while (score != maxScore && scoreAI != maxScore)
            {
                WinState playerWin;
                Choice choicePlayer;
                Choice choiceAI;

                RoundStart();
                choicePlayer = UserInput();
                choiceAI = (Choice)rand.Next(0, 3);
                PrintChoicePlayer(choicePlayer);
                PrintChoiceAI(choiceAI);
                playerWin = PlayerWinCheck(choicePlayer, choiceAI);
                PrintRoundResult(playerWin);

                if (playerWin == WinState.Gewonnen)
                {
                    score++;
                }
                else if (playerWin == WinState.Verloren)
                {
                    scoreAI++;
                }

                PrintScore(score, scoreAI);
                Console.ReadLine();
            }

            PrintFinalScore(score, scoreAI);
        }

        private static void PrintFinalScore(int score, int scoreAI)
        {
            Console.Clear();
            if (score > scoreAI)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                PrintScore(score, scoreAI);
                Console.WriteLine("\n\nGefeliciteerd! U heeft gewonnen.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                PrintScore(score, scoreAI);
                Console.WriteLine("\n\nDe computer heeft gewonnen.");
            }
            Console.ResetColor();
        }

        public static void PrintScore(int score, int scoreAI)
        {
            Console.WriteLine($"\nScore:\n\n\tSpeler: {score}\t-\tComputer: {scoreAI}");
        }

        public static void PrintRoundResult(WinState playerWin)
        {
            switch (playerWin)
            {
                case WinState.Gelijkspel:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("Gelijkspel.\n");
                    break;
                case WinState.Gewonnen:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("De speler heeft deze ronde gewonnen.\n");
                    break;
                case WinState.Verloren:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("De computer heeft gewonnen.\n");
                    break;
            }
            Console.ResetColor();
        }

        public static void PrintChoiceAI(Choice choiceAI)
        {
            Console.WriteLine($"\nDe computer speelt {choiceAI.ToString().ToLower()}. ");
        }

        public static WinState PlayerWinCheck(Choice choicePlayer, Choice choiceAI)
        {
            switch (choicePlayer)
            {
                case Choice.Steen:
                    if (choiceAI == Choice.Papier)
                    {
                        return WinState.Verloren;
                    }
                    else if (choiceAI == Choice.Schaar)
                    {
                        return WinState.Gewonnen;
                    }
                    break;
                case Choice.Papier:
                    if (choiceAI == Choice.Schaar)
                    {
                        return WinState.Verloren;
                    }
                    else if (choiceAI == Choice.Steen)
                    {
                        return WinState.Gewonnen;
                    }
                    break;
                case Choice.Schaar:
                    if (choiceAI == Choice.Steen)
                    {
                        return WinState.Verloren;
                    }
                    else if (choiceAI == Choice.Papier)
                    {
                        return WinState.Gewonnen;
                    }
                    break;
                default:
                    return WinState.Gelijkspel;
            }
            return WinState.Gelijkspel; //weet niet goed waarom deze lijn nog moet bijzitten
        }

        public static void RoundStart()
        {
            Console.Clear();
            Console.WriteLine("Schaar, steen, papier.\nDe eerste die 10 rondes wint heeft gewonnen.\nMaak u keuze.\n");
        }

        public static Choice UserInput()
        {
            bool validInput;
            string input;
            Choice choicePlayer = new();

            do
            {
                input = Console.ReadLine().ToLower();
                int enumParser = ErrorCheck(input);
                if (enumParser >= 0)
                {
                    validInput = true;
                    choicePlayer = (Choice)enumParser;
                }
                else
                {
                    validInput = false;
                    Console.WriteLine($"\"{input}\" is niet een geldige invoer.");
                }
            } while (!validInput);
            return choicePlayer;
        }

        private static void PrintChoicePlayer(Choice choicePlayer)
        {
            Console.WriteLine($"\nU koos om {choicePlayer.ToString().ToLower()} te spelen.");
        }

        public static int ErrorCheck(string input)
        {
            switch (input)
            {
                case "steen":
                case "0":
                    return 0;
                case "papier":
                case "1":
                    return 1;
                case "schaar":
                case "2":
                    return 2;
                default:
                    return -1;
            }
        }
    }
}
