using System;

namespace HangmanProject
{
    internal class PrintHang
    {
        public static void PrintHangman(int wrong) //skriva ut gubben i konsollen
        {
            if (wrong == 0) //Om 0 
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
            }
            else if (wrong == 1) //Om 1 fel
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("||    ||");
            }
            else if (wrong == 2) //Om 2 fel
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("========");
                Console.WriteLine("||    ||");
            }
            else if (wrong == 3) //Om 3 fel
            {
                Console.WriteLine("");
                Console.WriteLine("       |");
                Console.WriteLine("       |");
                Console.WriteLine("       |");
                Console.WriteLine("       |");
                Console.WriteLine("       |");
                Console.WriteLine("       |");
                Console.WriteLine("========");
                Console.WriteLine("||    ||");
            }
            else if (wrong == 4) //Om 4 fel
            {
                Console.WriteLine("\n +-----+");
                Console.WriteLine(" |     |");
                Console.WriteLine("       |");
                Console.WriteLine("       |");
                Console.WriteLine("       |");
                Console.WriteLine("       |");
                Console.WriteLine("       |");
                Console.WriteLine("========");
                Console.WriteLine("||    ||");
            }
            else if (wrong == 5) //Om 5 fel
            {
                Console.WriteLine("\n +-----+");
                Console.WriteLine(" |     |");
                Console.WriteLine(" O     |");
                Console.WriteLine("       |");
                Console.WriteLine("       |");
                Console.WriteLine("       |");
                Console.WriteLine("       |");
                Console.WriteLine("========");
                Console.WriteLine("||    ||");
            }
            else if (wrong == 6) //Om 6 fel
            {
                Console.WriteLine("\n +-----+");
                Console.WriteLine(" |     |");
                Console.WriteLine(" O     |");
                Console.WriteLine(" |     |");
                Console.WriteLine("       |");
                Console.WriteLine("       |");
                Console.WriteLine("       |");
                Console.WriteLine("========");
                Console.WriteLine("||    ||");
            }
            else if (wrong == 7) // Om 7 fel
            {
                Console.WriteLine("\n +-----+");
                Console.WriteLine(" |     |");
                Console.WriteLine(" O     |");
                Console.WriteLine("/|     |");
                Console.WriteLine("       |");
                Console.WriteLine("       |");
                Console.WriteLine("       |");
                Console.WriteLine("========");
                Console.WriteLine("||    ||");
            }
            else if (wrong == 8) //Om 8 fel
            {
                Console.WriteLine("\n +-----+");
                Console.WriteLine(" |     |");
                Console.WriteLine(" O     |");
                Console.WriteLine("/|\\    |");
                Console.WriteLine("       |");
                Console.WriteLine("       |");
                Console.WriteLine("       |");
                Console.WriteLine("========");
                Console.WriteLine("||    ||");
            }
            else if (wrong == 9) //Om 9 fel
            {
                Console.WriteLine("\n +-----+");
                Console.WriteLine(" |     |");
                Console.WriteLine(" O     |");
                Console.WriteLine("/|\\    |");
                Console.WriteLine("/      |");
                Console.WriteLine("       |");
                Console.WriteLine("       |");
                Console.WriteLine("========");
                Console.WriteLine("||    ||");
            }
            else if (wrong == 10) // Om 10 fel
            {
                Console.WriteLine("\n +-----+");
                Console.WriteLine(" |     |");
                Console.WriteLine(" O     |");
                Console.WriteLine("/|\\    |");
                Console.WriteLine("/ \\    |");
                Console.WriteLine("       |");
                Console.WriteLine("       |");
                Console.WriteLine("========");
                Console.WriteLine("||    ||");
            }
        }
    }
}
