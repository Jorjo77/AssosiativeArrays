using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //int [] numbers = Console.ReadLine()
            //    .Split()
            //    .Select(int.Parse)
            //    .ToArray();
            //int[] sorted = numbers.OrderByDescending(n => n).ToArray();
            //for (int i = 0; i < sorted.Length; i++)
            //{
            //    if (i>2)
            //    {
            //        break;
            //    }
            //    Console.Write(sorted[i]+" ");
            //}

            //List<int> numbers = Console.ReadLine()
            //    .Split()
            //    .Select(int.Parse)
            //    .OrderByDescending(n=>n)
            //    .ToList();

            //int count = numbers.Count >= 3 ? 3 : numbers.Count;

            //for (int i = 0; i < count; i++)

            //    Console.Write($"{numbers[i]} ");

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] sortedNumbers = numbers.OrderByDescending(n => n).ToArray();
            for (int i = 0; i < sortedNumbers.Length; i++)
            {
                Console.Write(sortedNumbers[i] + " ");
                if (i == 2)
                {
                    break;
                }
            }
        }
    }
}
