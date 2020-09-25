using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<double> numbers = Console.ReadLine()
            //    .Split(" ").Select(double.Parse).ToList();
            //SortedDictionary<double, int> result = new SortedDictionary<double, int>();
            //foreach (var number in numbers)
            //{
            //    if (result.ContainsKey(number))
            //    {
            //        result[number]++;
            //    }
            //    else
            //    {
            //        result.Add(number, 1);
            //    }
            //}
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Key} -> {item.Value}");
            //}

            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            SortedDictionary<double, int> counter = new SortedDictionary<double, int>();
            foreach (var number in numbers)
            {
                if (counter.ContainsKey(number))
                {
                    counter[number]++;
                }
                else
                {
                    counter[number] = 1;
                }
            }

            foreach (var kvp in counter)
            {
                Console.WriteLine($"{kvp.Key} -> { kvp.Value}");
            }
        }
    }
}
