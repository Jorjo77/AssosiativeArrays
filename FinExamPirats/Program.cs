using System;
using System.Collections.Generic;
using System.Linq;

namespace FinExamPirats
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> citiesPopulation = new Dictionary<string, int>();
            Dictionary<string, int> cityiesGold = new Dictionary<string, int>();
            string command;
            while ((command = Console.ReadLine()) != "Sail")
            {
                string[] splittedCommand = command.Split("||");
                string city = splittedCommand[0];
                int population = int.Parse(splittedCommand[1]);
                int gold = int.Parse(splittedCommand[2]);

                if (!citiesPopulation.ContainsKey(city))
                {
                    citiesPopulation[city] = 0;
                    cityiesGold[city] = 0;
                }
                citiesPopulation[city] += population;
                cityiesGold[city] += gold;
            }

            string events;
            while ((events = Console.ReadLine()) != "End")
            {
                string[] splittedEvents = events.Split("=>");
                if (splittedEvents[0] == "Plunder")
                {
                    string town = splittedEvents[1];
                    int kiledPeople = int.Parse(splittedEvents[2]);
                    int stolenGold = int.Parse(splittedEvents[3]);
                    if (citiesPopulation.ContainsKey(town))
                    {
                        citiesPopulation[town] -= kiledPeople;
                        cityiesGold[town] -= stolenGold;
                        Console.WriteLine($"{town} plundered! {stolenGold} gold stolen, {kiledPeople} citizens killed.");
                    }
                    if (citiesPopulation[town] == 0 || cityiesGold[town] == 0)
                    {
                        citiesPopulation.Remove(town);
                        cityiesGold.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }
                }
                else if (splittedEvents[0] == "Prosper")
                {
                    string town = splittedEvents[1];
                    int adititionalGold = int.Parse(splittedEvents[2]);
                    if (adititionalGold >= 0)
                    {
                        cityiesGold[town] += adititionalGold;
                        Console.WriteLine($"{adititionalGold} gold added to the city treasury. {town} now has {cityiesGold[town]} gold.");
                    }
                    else
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                }
            }
            var sortedCitiesGold = cityiesGold.OrderByDescending(kvp => kvp.Value)
                .ThenBy(kvp => kvp.Key).ToList();

            if (sortedCitiesGold != null)
            {
                Console.WriteLine($"Ahoy, Captain! There are {sortedCitiesGold.Count} wealthy settlements to go to:");
                foreach (var kvp in sortedCitiesGold)
                {
                    string name = kvp.Key;
                    int people = citiesPopulation[name];

                    Console.WriteLine($"{name} -> Population: {people} citizens, Gold: {kvp.Value} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
