using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] keymaterialNames = new string[]
            //{
            //    "shards","fragments","motes"
            //};
            //Dictionary<string, long> keyMaterials = new Dictionary<string, long>();
            //Dictionary<string, long> junk = new Dictionary<string, long>();
            //keyMaterials["shards"] = 0;
            //keyMaterials["fragments"] = 0;
            //keyMaterials["motes"] = 0;
            //string itemObtained = string.Empty;
            //bool obtained = false;
            //while (!obtained)
            //{
            //    string[] inputArgs = Console.ReadLine()
            //        .Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            //    for (int i = 0; i < inputArgs.Length; i += 2)
            //    {
            //        long qty = long.Parse(inputArgs[i]);
            //        string material = inputArgs[i + 1].ToLower();
            //        if (keymaterialNames.Contains(material))
            //        {
            //            keyMaterials[material] += qty;

            //            if (keyMaterials.Any(m => m.Value >= 250))
            //            {
            //                if (material == "shards")
            //                {
            //                    itemObtained = "Shadowmourne";
            //                }
            //                else if (material == "fragments")
            //                {
            //                    itemObtained = "Valanyr";
            //                }
            //                else
            //                {
            //                    itemObtained = "Dragonwrath";
            //                }
            //                keyMaterials[material] -= 250;
            //                obtained = true;
            //                break;
            //            }
            //        }
            //        else
            //        {
            //            if (!junk.ContainsKey(material))
            //            {
            //                junk[material] = 0;
            //            }
            //            junk[material] += qty;
            //        }
            //    }
            //}
            //Console.WriteLine($"{itemObtained} obtained!");
            //keyMaterials = keyMaterials.OrderByDescending(kvp => kvp.Value)
            //    .ThenBy(kvp => kvp.Key)
            //    .ToDictionary(a => a.Key, b => b.Value);
            ////с това презаписване старото го губим, но то не ни трябва!
            //foreach (var kvp in keyMaterials)
            //{
            //    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            //}
            //junk = junk.OrderBy(kvp => kvp.Key)
            //    .ToDictionary(a => a.Key, b => b.Value);
            //foreach (var kvp in junk)
            //{
            //    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            //}

            Dictionary<string, long> keyMaterials = new Dictionary<string, long>();
            keyMaterials["shards"] = 0;
            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("motes", 0);
            Dictionary<string, long> junkMaterials = new Dictionary<string, long>();
            long quantity = 0;
            string resourceName = "";
            while (true)
            {
                string input = Console.ReadLine();
                string[] splitedInput = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int i = 0; i < splitedInput.Length; i += 2)
                {
                    quantity = long.Parse(splitedInput[i]);
                    resourceName = splitedInput[i + 1].ToLower();
                    if (resourceName == "shards" || resourceName == "fragments" || resourceName == "motes")
                    {
                        keyMaterials[resourceName] += quantity;
                        if (keyMaterials[resourceName] >= 250)
                        {
                            if (resourceName == "shards")
                            {
                                Console.WriteLine("Shadowmorune obtained!");
                            }
                            else if (resourceName == "fragments")
                            {
                                Console.WriteLine("Valanyr obtained!");
                            }
                            else if (resourceName == "motes")
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                            }
                            break;
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(resourceName))
                        {
                            junkMaterials.Add(resourceName, 0);
                        }
                        junkMaterials[resourceName] += quantity;
                    }
                }
                if (keyMaterials[resourceName] >= 250)
                {
                    keyMaterials[resourceName] -= 250;
                    break;
                }
            }
            var sortedKeyMaterials = keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key)
                .ToDictionary(a => a.Key, b => b.Value); 
            var sortedJunk = junkMaterials.OrderBy(x => x.Key).ToDictionary(a => a.Key, b => b.Value);

            foreach (var resource in sortedKeyMaterials)
            {
                Console.WriteLine($"{resource.Key}: {resource.Value}");
            }
            foreach (var junk in sortedJunk)
            {
                Console.WriteLine($"{junk.Key}: {junk.Value}");
            }
            //на това решение нулевите тестове излизат, но хваща само 10% в Джъдж!!!!?
        }
    }
}

