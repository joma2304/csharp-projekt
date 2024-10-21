using System;
using System.Collections.Generic;

namespace HangmanProject
{
    internal class PrintWrd
    {
        public static int PrintWord(List<char> guessedLetters, string randomWord)
        {
            int counter = 0;
            int rightLetters = 0;
            Console.WriteLine(); // Tom rad för struktur
            foreach (char i in randomWord)
            {
                if (guessedLetters.Contains(i))
                {
                    Console.Write(i + " "); //Bokstaven + mellanslag skrivs ut
                    rightLetters += 1;
                }
                else
                {
                    Console.Write("_ "); // Visa ett understrykningstecken för varje bokstav som inte gissats rätt än
                }
                counter += 1;
            }
            return rightLetters;
        }

    }
}
