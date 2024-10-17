using System;
using System.Collections.Generic;
using System.Text;

namespace HangmanProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Huvudloop för spelet
            do
            {
                PlayGame(); // Starta spelet
            } while (PlayAgain()); // Kolla om spelaren vill spela igen
        }

        static void PlayGame()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Random random = new Random();
            List<string> wordDictionary = new List<string>
            {
                "bord", "stol", "sked", "bok", "säng", "dator", "bil", "cykel", "gitarr",
                "boll", "väska", "dusch", "penna", "glas", "skärm", "spegel", "kudde",
                "tårta", "blomma", "tavla", "klänning", "keps", "soffa",
                "telefon", "kamera", "klocka", "sax", "lampa", "filt", "tallrik", "sko",
                "nyckel", "gitarr", "tröja", "fjäder", "hink", "handduk", "bälte", "hatt"
            };

            int index = random.Next(wordDictionary.Count);
            string randomWord = wordDictionary[index];

            int lengthOfWordToGuess = randomWord.Length;
            int amountOfTimesWrong = 0;
            List<char> currentLettersGuessed = new List<char>();
            int currentLettersRight = 0;

            while (amountOfTimesWrong != 6 && currentLettersRight != lengthOfWordToGuess)
            {
                Console.Clear(); // Rensa skärmen
                Console.WriteLine("Välkommen till Hängagubbe :)");
                Console.WriteLine("------------------------------");
                PrintHang.PrintHangman(amountOfTimesWrong); // Rita gubben

                // Skriver ordet med bokstäver för rätt gissade bokstäver och understreck för bokstäver som inte gissats rätt än
                currentLettersRight = PrintWrd.PrintWord(currentLettersGuessed, randomWord);
                Console.WriteLine(); // ny tom rad för att dela upp så det inte blir så trångt i konsollen

                Console.Write("\nBokstäver som du har gissat på: ");
                foreach (char letter in currentLettersGuessed) // Loopar igenom bokstäver som gissats på
                {
                    Console.Write(letter + ", "); // Skriver ut bokstäver som gissats på
                }

                Console.Write("\n\nGissa på en bokstav: ");
                string? input = Console.ReadLine();

                // Kontrollera om input är tom eller bara innehåller mellanslag
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Ingen bokstav angavs, försök igen!"); // Meddelande för tom input
                    Console.WriteLine("Tryck på valfri tangent för att fortsätta");
                    Console.ReadKey(); // Vänta på att användaren trycker på en tangent
                    continue;
                }

                char letterGuessed = input.Trim()[0]; //så att endast första bokstaven gissas på ifall du skriver in fler än 1

                // Kontrollera om bokstaven redan har gissats
                if (currentLettersGuessed.Contains(letterGuessed))
                {
                    Console.WriteLine("\nDu har redan gissat på denna bokstaven, välj en ny!"); // Skrivs ut vid upprepad gissning
                    Console.WriteLine("Tryck på valfri tangent för att fortsätta");
                    Console.ReadKey(); // Vänta på att användaren trycker på en tangent
                    continue;
                }

                // Lägg till bokstaven till listan över gissade bokstäver
                currentLettersGuessed.Add(letterGuessed);

                // Kontrollera om gissningen är korrekt
                if (randomWord.Contains(letterGuessed)) // Ifall bokstaven finns i ordet
                {
                    // Inget mer behövs här eftersom PrintWord redan fixar utskriften
                }
                else // Ifall bokstaven inte finns i ordet
                {
                    amountOfTimesWrong += 1; // Öka antalet fel gissningar
                }

                // Kontrollera om spelaren har vunnit
                currentLettersRight = PrintWrd.PrintWord(currentLettersGuessed, randomWord);

                if (currentLettersRight == randomWord.Length) // Om alla bokstäver är gissade rätt
                {
                    Console.Clear(); // Rensa konsollen så det inte blir dubblett av gubben
                    Console.WriteLine("VINST!");
                    PrintHang.PrintHangman(amountOfTimesWrong); // Rita hänggubben
                    PrintWrd.PrintWord(currentLettersGuessed, randomWord); // Skriver ut ordet under gubben
                    Console.WriteLine($"\nGrattis, du vann! Ordet var: {randomWord}"); // skriv ut vid vinst
                    Console.WriteLine("\nTryck 1 för att spela igen, tryck 2 för att avsluta");
                }

                // Kontrollera om spelaren har förlorat
                if (amountOfTimesWrong == 6) // Ifall spelaren gissat fel 6 gånger
                {
                    Console.Clear(); // Rensa konsollen så det inte blir dubblett av gubben
                    Console.WriteLine("FÖRLUST!");
                    PrintHang.PrintHangman(amountOfTimesWrong); // Rita hänggubben innan förlora texten kommer
                    PrintWrd.PrintWord(currentLettersGuessed, randomWord); // Skriver ut ordet under gubben
                    Console.WriteLine($"\nDu förlorade! Ordet var: {randomWord}"); // Skriv ut vid förlust
                    Console.WriteLine("\nTryck 1 för att spela igen, tryck 2 för att avsluta.");
                }
            }
        }

        static bool PlayAgain()
        {
            Console.Write("\nDitt val: ");
            string? input = Console.ReadLine();
            if (input == "1")
            {
                return true; // Spela igen
            }
            else if (input == "2")
            {
                return false; // Avsluta
            }
            else
            {
                Console.WriteLine("Ogiltigt val. Välj 1 eller 2.");
                return PlayAgain(); // Fråga igen om ogiltigt val
            }
        }
    }
}






