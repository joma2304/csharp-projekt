using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace HangmanProject
{
    internal static class WordManager
    {
        private const string FilePath = "words.json"; 

        public static List<string> LoadWords()
        {
            if (File.Exists(FilePath)) //Ifall words.json finns
            {
                string json = File.ReadAllText(FilePath);
                return JsonSerializer.Deserialize<List<string>>(json) ?? new List<string>(); //returnera lista med innehållet
            }
            return new List<string>(); // Returnera en tom lista om filen inte finns
        }

        public static void SaveWords(List<string> words)
        {
            string json = JsonSerializer.Serialize(words, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
        }

        public static void AddWord(string word)
        {
            var words = LoadWords(); //Laddar in orden

            // Omvandla både det nya ordet och de befintliga orden till små bokstäver för att kunna jämföra
            string wordToAdd = word.ToLower();

            // Kontrollera om ordet redan finns
            if (words.Contains(wordToAdd))
            {
                Console.WriteLine($"Ordet '{word}' finns redan i listan.");
                return; // Avsluta metoden om ordet redan finns
            }

            words.Add(wordToAdd); // Lägg till det nya ordet i listan
            SaveWords(words); // Spara de uppdaterade orden
            Console.WriteLine($"Ordet '{word}' har lagts till.");
        }

        public static void ShowAllWords()
        {
            List<string> words = LoadWords();

            if (words.Count == 0) //Om antalet ord = 0
            {
                Console.WriteLine("Inga ord finns tillagda.");
            }
            else
            {
                Console.WriteLine("Tillagda ord:");
                Console.WriteLine("-----------");
                for (int i = 0; i < words.Count; i++) //Loopar igenom orden
                {
                    Console.WriteLine($"{i}: {words[i]}"); // Skriv ut ordet med deras index
                }
            }
            Console.WriteLine("\nTryck valfri tangent för att gå tillbaks till meny");
            Console.ReadKey();
        }

        //Visa ord till remove metoden för att man inte ska behöva trycka på en tangent för att få upp instruktioner
        public static void ShowAllWordsForDelete()
        {
            List<string> words = LoadWords();

            if (words.Count == 0)
            {
                Console.WriteLine("Inga ord finns tillagda.");
            }
            else
            {
                Console.WriteLine("Tillagda ord:");
                Console.WriteLine("-----------");
                for (int i = 0; i < words.Count; i++) //Loopa igenom orden
                {
                    Console.WriteLine($"{i}: {words[i]}"); // Skriv ut ordet med deras index
                }
            }
        }

        public static void RemoveWord()
        {
            List<string> words = LoadWords(); // Hämta alla ord

            if (words.Count == 0) //Ifall antalet ord = 0
            {
                Console.WriteLine("Inga ord finns att ta bort.");
                Console.WriteLine("Tryck på valfri tangent för att gå tillbaka till menyn.");
                Console.ReadKey();
                return;
            }

            // Visa alla ord med index direkt
            ShowAllWordsForDelete();

            // Instruktion för hur man tar bort ord
            Console.Write($"\nAnge indexet för ordet som ska tas bort (0 - {words.Count - 1}): "); // -1 eftersom indexet börjar på 0 och inte 1

            // Validera inputen genom att göra inputen till ett heltal, och kolla så att indexen är ett gilltligt värde (inte mindre än 0 och större än antalet ord i listan)
            if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < words.Count)
            {
                string wordToRemove = words[index]; // Hämta ordet med det angivna indexet
                words.RemoveAt(index); // Ta bort ordet
                SaveWords(words); // Spara de uppdaterade orden
                Console.WriteLine($"Ordet '{wordToRemove}' har tagits bort.");
            }
            else
            {
                Console.WriteLine("Ogiltigt index. Inget ord togs bort.");
            }

            Console.WriteLine("Tryck på valfri tangent för att gå tillbaka till menyn.");
            Console.ReadKey();
        }



        public static void AddWords()
        {
            Console.Write("Ange ordet att lägga till: ");
            string? newWord = Console.ReadLine(); //Läs in ordet från konsollen

            if (!string.IsNullOrWhiteSpace(newWord)) //Ifall inputen innehåller något
            {
                AddWord(newWord); // Lägg till nya ordet med AddWord metoden
            }
            else
            {
                Console.WriteLine("Ogiltigt ord. Ingen åtgärd vidtogs.");
            }

            Console.WriteLine("Tryck på valfri tangent för att återgå till hantera ordmenyn.");
            Console.ReadKey();
        }
    }
}


