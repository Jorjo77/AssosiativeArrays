using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string, List<string>> forceBook = new Dictionary<string, List<string>>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command== "Lumpawaroo")
                {
                    break;      
                }
                // string[] splitedCommand = command.Split(new string[] {" | ", " -> "};
                bool memberExists = false;
                if (command.Contains("|")) 
                {
                    string[] splitedCommand = command.Split(" | ");
                    string side = splitedCommand[0];
                    string user = splitedCommand[1];
                    if (!forceBook.ContainsKey(side))
                    {
                        forceBook[side] = new List<string>();
                    }

                    foreach (var kvp in forceBook)
                    {
                        if (kvp.Value.Contains(user))
                        {
                            memberExists = true;
                            break;
                        }
                    }
                    if (!forceBook[side].Contains(user)&&!memberExists)
                    {
                        forceBook[side].Add(user);
                    }
                }
                else if (command.Contains("->"))
                {
                    string[] splitedCommand = command.Split(" -> ");
                    string side = splitedCommand[1];
                    string user = splitedCommand[0];

                    string cuurentSide = "";
                    foreach (var kvp in forceBook)
                    {
                        if (kvp.Value.Contains(user))
                        {
                            memberExists = true;
                            cuurentSide = kvp.Key;
                            break;
                        }
                    }
                    if (memberExists)
                    {
                        forceBook[cuurentSide].Remove(user);
                    }
                    if (!forceBook.ContainsKey(side))
                    {
                        forceBook[side] = new List<string>();
                    }
                    if (!forceBook[side].Contains(user))
                    {
                        forceBook[side].Add(user);
                    }

                    Console.WriteLine($"{user} joins the {side} side!");
                }
            }
            var sortedForceBook = forceBook.OrderByDescending(x => x.Value.Count)
                .ThenBy(x=>x.Key);
               
            foreach (var kvp in sortedForceBook.Where(x=>x.Value.Count>0))
            {
                    Console.WriteLine($"Side: {kvp.Key.Trim()}, Members: {kvp.Value.Count}");

                var sortedUsers = kvp.Value.OrderBy(x => x);
                foreach (var value in sortedUsers)
                {
                    Console.WriteLine($"! {value}");
                }
            }
        }
    }
}
