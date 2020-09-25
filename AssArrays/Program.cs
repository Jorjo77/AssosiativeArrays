using System;
using System.Collections.Generic;

namespace AssArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex.1
            Dictionary<string, int> students = new Dictionary<string, int>();
            //Ex.2
            var fruits = new Dictionary<string, double>();

            fruits["banana"] = 2.20;

            fruits["apple"] = 1.40;

            fruits["kiwi"] = 3.20;

            //SortedDictionaries:
            var fruits2 = new SortedDictionary<string, double>();

            fruits["kiwi"] = 4.50;

            fruits["orange"] = 2.50;

            fruits["banana"] = 2.20;

            //Add(key, value) method and Remove(key) method:
            var airplanes = new Dictionary<string, int>();

            airplanes.Add("Boeing 737", 130);

            airplanes.Remove("Boeing 737");
            //ContainsKey(key)
            var dictionary = new Dictionary<string, int>();

            dictionary.Add("Airbus A320", 150);

            if (dictionary.ContainsKey("Airbus A320"))

                Console.WriteLine($"Airbus A320 key exists");
            //ContainsValue(value)
            var dictionary2 = new Dictionary<string, int>();

            dictionary.Add("Airbus A320", 150);

            Console.WriteLine(dictionary.ContainsValue(150)); //true

            Console.WriteLine(dictionary.ContainsValue(100)); //false
            //PrintDictionary:
            foreach (var num in counts)

                Console.WriteLine($"{num.Key} -> {num.Value}");
        }
    }
}
