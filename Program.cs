using System;
using System.Collections.Generic;
using System.Text;

namespace HangmanProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                ShowMainMenu(); // Visa huvudmenyn
            } while (true); // Huvudmenyn är en oändlig loop
        }

        static void ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine("H U V U D M E N Y");
            Console.WriteLine("-----------------");
            Console.WriteLine("1. Spela Hängagubbe");
            Console.WriteLine("2. Hantera spelets ord");
            Console.WriteLine("3. Avsluta");

            Console.Write("\nDitt val: ");
            string? input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    PlayGame(); // Starta spelet
                    break;
                case "2":
                    ManageWords(); // hantera orden
                    break;
                case "3":
                    Console.Clear(); // Rensa konsolen
                    Environment.Exit(0); // Avsluta programmet
                    break;
                default:
                    Console.WriteLine("Ogiltigt val. Vänligen välj 1, 2 eller 3. Tryck på valfri tangent för att testa igen.");
                    Console.ReadKey(); // Vänta på att användaren trycker på en tangent
                    break;
            }
        }

        static void ManageWords()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Hantera ord");
                Console.WriteLine("1. Visa alla ord");
                Console.WriteLine("2. Lägga till ett nytt ord");
                Console.WriteLine("3. Ta bort ett ord");
                Console.WriteLine("4. Gå tillbaks till huvudmenyn");

                Console.Write("\nDitt val: ");
                string? input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        WordManager.ShowAllWords(); // Visa alla tillagda ord
                        break;
                    case "2":
                        WordManager.AddWords(); // Lägga till ett nytt ord
                        break;
                    case "3":
                        WordManager.RemoveWord(); // Ta bort ett ord
                        break;
                    case "4":
                        return; // Tillbaks till huvudmenyn
                    default:
                        Console.WriteLine("Ogiltigt val. Vänligen välj 1, 2, 3 eller 4.");
                        break;
                }
            } while (true);
        }


        static void PlayGame()
        {
            // För att åäö ska fungera
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Random random = new Random();
            List<string> wordDictionary = WordManager.LoadWords(); // Hämta ord från WordManager och lägger till i wordDictionary

            if (wordDictionary.Count == 0) //Ifall det inte finns några ord tillagda
            {
                Console.WriteLine("Inga ord tillgängliga att spela med. Lägga till ord först för att spela.");
                Console.WriteLine("\nTryck på valfri tangent för att återgå till huvudmenyn.");
                Console.ReadKey();
                return;
            }

            int index = random.Next(wordDictionary.Count); //slumpat index från ordlistan
            string randomWord = wordDictionary[index]; //Hämtar slumpat ord med hjälp av det slumpade indexet

            int lengthOfWordToGuess = randomWord.Length; //Längden på det slumpade ordet
            int amountOfTimesWrong = 0; //Antalet fel gissningar (börjar på 0)
            List<char> currentLettersGuessed = new List<char>(); //Lista för bokstäver som gissats på
            int currentLettersRight = 0; // Antalet rätt gissningar (börjar på 0)

            //Sålänge antalet fel gissningar inte är 6 och antalet rätt gissningar inte är lika många som ordets längd
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

                char letterGuessed = char.ToLower(input.Trim()[0]);//så att endast första bokstaven gissas på ifall du skriver in fler än 1 och så att den blir till liten bokstav

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
                    Console.WriteLine("VINST :)");
                    PrintHang.PrintHangman(amountOfTimesWrong); // Rita hänggubben
                    PrintWrd.PrintWord(currentLettersGuessed, randomWord); // Skriver ut ordet under gubben
                    Console.WriteLine($"\nGrattis, du vann! Ordet var: {randomWord}"); // skriv ut vid vinst
                    Console.WriteLine("\nTryck på valfri tangent för att återgå till huvudmenyn.");
                    Console.ReadKey();
                }

                // Kontrollera om spelaren har förlorat
                if (amountOfTimesWrong == 6) // Ifall spelaren gissat fel 6 gånger
                {
                    Console.Clear(); // Rensa konsollen så det inte blir dubblett av gubben
                    Console.WriteLine("FÖRLUST :(");
                    PrintHang.PrintHangman(amountOfTimesWrong); // Rita hänggubben innan förlora texten kommer
                    PrintWrd.PrintWord(currentLettersGuessed, randomWord); // Skriver ut ordet under gubben
                    Console.WriteLine($"\nDu förlorade! Ordet var: {randomWord}"); // Skriv ut vid förlust
                    Console.WriteLine("\nTryck på valfri tangent för att återgå till huvudmenyn.");
                    Console.ReadKey();
                }
            }
        }
    }
}







