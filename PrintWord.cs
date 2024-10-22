using System;
using System.Collections.Generic;

namespace HangmanProject
{
    internal class PrintWrd
    {
        public static int PrintWord(List<char> guessedLetters, string randomWord)
        {
            int counter = 0; //Håller reda på antalet bokstäver
            int rightLetters = 0; //Håller reda på antalet rätt bokstäver
            Console.WriteLine(); // Tom rad för struktur
            foreach (char i in randomWord) //Loopar genom varje bokstav i random ordet
            {
                if (guessedLetters.Contains(i))  //Ifall ordet innehåller gissad bokstav
                {
                    Console.Write(i + " "); //Bokstaven + mellanslag skrivs ut
                    rightLetters += 1; // Ökar antalet rätt gissade bokstäver med 1
                }
                else //Annars
                {
                    Console.Write("_ "); // Visa ett understrykningstecken för varje bokstav som inte gissats rätt än
                }
                counter += 1; //Öka antalet gissade bokstäver med 1
            }
            return rightLetters; //Returnera antalet rätt gissade bokstäver
        }

    }
}
