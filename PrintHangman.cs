using System;

namespace HangmanProject
{
    internal class PrintHang
    {
        public static void PrintHangman(int wrong)
        {
            if (wrong == 0)
            {
                Console.WriteLine("\n +-----+");
                Console.WriteLine(" |     |");
                Console.WriteLine("       |");
                Console.WriteLine("       |");
                Console.WriteLine("       |");
                Console.WriteLine("       |");
                Console.WriteLine("    ====");
            }
            else if (wrong == 1)
            {
                Console.WriteLine("\n +-----+");
                Console.WriteLine(" |     |");
                Console.WriteLine(" O     |");
                Console.WriteLine("       |");
                Console.WriteLine("       |");
                Console.WriteLine("       |");
                Console.WriteLine("    ====");
            }
            else if (wrong == 2)
            {
                Console.WriteLine("\n +-----+");
                Console.WriteLine(" |     |");
                Console.WriteLine(" O     |");
                Console.WriteLine(" |     |");
                Console.WriteLine("       |");
                Console.WriteLine("       |");
                Console.WriteLine("    ====");
            }
            else if (wrong == 3)
            {
                Console.WriteLine("\n +-----+");
                Console.WriteLine(" |     |");
                Console.WriteLine(" O     |");
                Console.WriteLine("/|     |");
                Console.WriteLine("       |");
                Console.WriteLine("       |");
                Console.WriteLine("    ====");
            }
            else if (wrong == 4)
            {
                Console.WriteLine("\n +-----+");
                Console.WriteLine(" |     |");
                Console.WriteLine(" O     |");
                Console.WriteLine("/|\\    |");
                Console.WriteLine("       |");
                Console.WriteLine("       |");
                Console.WriteLine("    ====");
            }
            else if (wrong == 5)
            {
                Console.WriteLine("\n +-----+");
                Console.WriteLine(" |     |");
                Console.WriteLine(" O     |");
                Console.WriteLine("/|\\    |");
                Console.WriteLine("/      |");
                Console.WriteLine("       |");
                Console.WriteLine("    ====");
            }
            else if (wrong == 6)
            {
                Console.WriteLine("\n +-----+");
                Console.WriteLine(" |     |");
                Console.WriteLine(" O     |");
                Console.WriteLine("/|\\    |");
                Console.WriteLine("/ \\    |");
                Console.WriteLine("       |");
                Console.WriteLine("    ====");
            }
        }
    }
}
