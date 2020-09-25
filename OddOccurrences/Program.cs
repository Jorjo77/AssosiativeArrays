using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] words = Console.ReadLine()
            //                           .Split();

            //Dictionary<string, int> countedWords = new Dictionary<string, int>();

            //foreach (var word in words)
            //{
            //    string wordInLowerCase = word.ToLower();
            //    if (!countedWords.ContainsKey(wordInLowerCase))
            //    {
            //        countedWords.Add(wordInLowerCase, 0);
            //    }
            //    countedWords[wordInLowerCase]++;
            //}

            //    foreach (var symbol in countedWords)
            //    {
            //        if (symbol.Value%2!=0)
            //        {
            //            Console.Write(symbol.Key+" ");
            //        }
            //    }
            //}



            string[] elements = Console.ReadLine()
                .Split()
                .ToArray();
            Dictionary<string, int> repeatedElements = new Dictionary<string, int>();
            foreach (var element in elements)
            {
                string wordToLower = element.ToLower();
                if (!repeatedElements.ContainsKey(wordToLower))
                {
                    repeatedElements.Add(wordToLower, 0);
                }
                repeatedElements[wordToLower]++;

            }
            foreach (var kvp in repeatedElements)
            {
                if (kvp.Value%2!=0)
                {
                    Console.Write(kvp.Key + " ");
                }
            }
        }
    }
}
