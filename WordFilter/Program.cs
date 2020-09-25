using System;
using System.Linq;

namespace WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] words = Console.ReadLine()
            //    .Split()
            //    .Where(w => w.Length % 2 == 0)
            //    .ToArray();
            //foreach (var word in words)
            //{
            //    Console.WriteLine(word);
            //}

            string[] words = Console.ReadLine()
                .Split().ToArray();
            string[] sortedWords = words.Where(w => w.Length % 2 == 0)
                .ToArray();
            foreach (var word in sortedWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
