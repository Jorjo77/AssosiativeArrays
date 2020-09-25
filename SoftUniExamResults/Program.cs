using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> contest = new Dictionary<string, int>();
            Dictionary<string, List<string>> languageSubmissions = new Dictionary<string, List<string>>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "exam finished")
                {
                    break;
                }
                string[] splittedCommand = command.Split("-");
                string username = splittedCommand[0];
                if (!command.Contains("banned"))
                {
                    string language = splittedCommand[1];
                    int points = int.Parse(splittedCommand[2]);
                    if (!contest.ContainsKey(username))
                    {
                        contest.Add(username, 0);
                    }
                    contest[username] = points;
                    if (!languageSubmissions.ContainsKey(language))
                    {
                        languageSubmissions.Add(language, new List<string>());
                    }
                    languageSubmissions[language].Add(username);
                }
                else
                {
                    if (contest.ContainsKey(username))
                    {
                        contest.Remove(username);
                    }
                }
            }

            Console.WriteLine("Results:");
            foreach (var kvp in contest.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{kvp.Key} | {kvp.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var kvp in languageSubmissions.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value.Count}");
            }
        }
    }
}
