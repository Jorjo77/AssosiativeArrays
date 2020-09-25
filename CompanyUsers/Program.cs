using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {


            //Dictionary<string, List<string>> companyData = new Dictionary<string, List<string>>();
            //string input;
            //while ((input = Console.ReadLine()) != "End")
            //{
            //    string[] inputInArguments = input.Split("->", StringSplitOptions.RemoveEmptyEntries);
            //    string company = inputInArguments[0];
            //    string employee = inputInArguments[1];
            //    if (!companyData.ContainsKey(company))
            //    {
            //        companyData[company] = new List<string>();
            //        companyData[company].Add(employee);
            //    }
            //    if (!companyData.Values.Any(l=>l.Contains(employee)))
            //    {
            //        companyData[company].Add(employee);
            //    }

            //}
            //var orderedCompanyData = companyData.OrderBy(c => c.Key).ToList();
            //foreach (var company in orderedCompanyData)
            //{
            //    Console.WriteLine(company.Key);

            //    for (int i = 0; i < company.Value.Count; i++)
            //    {
            //        Console.WriteLine($"--{company.Value[i]}");
            //    }
            //}


            Dictionary<string, List<string>> emploiesRegister = new Dictionary<string, List<string>>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command=="End")
                {
                    break;
                }
                string[] splitedCommand = command.Split(" -> ");
                string company = splitedCommand[0];
                string employee = splitedCommand[1];
                if (!emploiesRegister.ContainsKey(company))
                {
                    emploiesRegister.Add(company, new List<string>());
                }
                if (!emploiesRegister[company].Contains(employee))
                {
                    emploiesRegister[company].Add(employee);
                }

            }
            var orderedEmploiesRegister = emploiesRegister.OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
            foreach (var kvp in orderedEmploiesRegister)
            {
                Console.WriteLine(kvp.Key);
                Console.WriteLine($"-- {string.Join("\n-- ", kvp.Value)}");
            }
        }
    }
}
