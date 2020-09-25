using System;
using System.Collections.Generic;

namespace AminerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, int> result = new Dictionary<string, int>();
            //while (true)
            //{
            //    string resource = Console.ReadLine();
            //    if (resource == "stop")
            //    {
            //        break;
            //    }
            //    int quantity = int.Parse(Console.ReadLine());
            //    if (!result.ContainsKey(resource))
            //    {
            //        result[resource] = 0;
            //    }
            //    result[resource] += quantity;
            //}
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Key} -> {item.Value}");
            //}


            Dictionary<string, int> resourses = new Dictionary<string, int>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "stop")
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());

                if (!resourses.ContainsKey(command))
                {
                    resourses.Add(command, 0);
                }
                resourses[command] += quantity;
            }
            foreach (var resource in resourses)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
