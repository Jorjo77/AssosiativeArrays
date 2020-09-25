using System;
using System.Collections.Generic;

namespace WordSinonims
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();
            //    int numberWords = int.Parse(Console.ReadLine());
            //    for (int i = 0; i < numberWords; i++)
            //    {
            //        string word = Console.ReadLine();
            //        string synonym = Console.ReadLine();
            //        if (!words.ContainsKey(word))
            //        {
            //            words.Add (word, new List<string>());
            //        }
            //        words[word].Add(synonym);
            //    }
            //    foreach (var word in words)
            //    {
            //        Console.WriteLine($"{word.Key} - "+ $"{String.Join(", ", word.Value)}");
            //    }

            int numberWords = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> sinonyms = new Dictionary<string, List<string>>();
            for (int i = 0; i < numberWords; i++)
            {
                string word = Console.ReadLine();
                string sinonym = Console.ReadLine();
                if (!sinonyms.ContainsKey(word))
                {
                    sinonyms.Add(word, new List<string>());
                }
                sinonyms[word].Add(sinonym);
            }
            foreach (var word in sinonyms)
            {
                Console.WriteLine($"{word.Key} - "+$" {string.Join(", ", word.Value)}");
            }
        }
    }
}
