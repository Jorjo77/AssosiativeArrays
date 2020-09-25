using System;
using System.Collections.Generic;
using System.Linq;

namespace CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = Console.ReadLine();


            //Dictionary<char, int> result = new Dictionary<char, int>();
            //for (int i = 0; i < text.Length; i++)
            //{
            //    char currLetter = text[i];
            //    if (currLetter != ' ')//Ако не е спейсче!;-)) тогава!
            //    {
            //        if (!result.ContainsKey(currLetter))
            //        {
            //            //result.Add(currLetter, 1);!!!еквивалентни са, просто различен синтаксис
            //            result[currLetter] = 0;
            //        }
            //        result[currLetter]++;
            //        //else !!!еквивалентни са, просто различен синтаксис
            //        //{
            //        //    result[currLetter]++;
            //        //}
            //    }

            //}
            //foreach (var letter in result)
            //{
            //    Console.WriteLine($"{letter.Key} -> {letter.Value}");
            //}

            string text = Console.ReadLine();
            Dictionary<char, int> counter = new Dictionary<char, int>();
            for (int i = 0; i < text.Length; i++)
            {
                char curr = text[i];
                if (curr!=' ')
                {
                    if (!counter.ContainsKey(curr))
                    {
                        counter.Add(curr, 0);
                    }
                    counter[curr]++;
                }

            }
            foreach (var character in counter)
            {
                Console.WriteLine($"{character.Key} -> {character.Value}");
            }
        }
    }
}
