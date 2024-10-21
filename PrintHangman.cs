using System;

namespace HangmanProject
{
    internal class PrintHang
    {
        public static void PrintHangman(int wrong) //skriva ut gubben i konsollen
        {
            if (wrong == 0) //Om 0 fel skrivs själva ställningen ut
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
            else if (wrong == 1) //Om ett fel skrivs huvudet ut
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
            else if (wrong == 2) //Om 2 fel skrivs magen ut
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
            else if (wrong == 3) // Om 3 fel skrivs en arm ut
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
            else if (wrong == 4) //Om 4 fel skrivs en arm till ut
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
            else if (wrong == 5) //Om 5 fel skrivs ett ben ut
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
            else if (wrong == 6) // Om 6 fel skrivs hela gubben ut
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
