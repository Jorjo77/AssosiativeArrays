using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            //dictionary<string, decimal> productsprices = new dictionary<string, decimal>();
            //dictionary<string, long> productsquantyties = new dictionary<string, long>();
            //string input;

            //while ((input = console.readline()) != "buy")
            //{
            //    string[] inputinarguments = input
            //        .split(' ', stringsplitoptions.removeemptyentries);
            //    string product = inputinarguments[0];
            //    decimal price = decimal.parse(inputinarguments[1]);
            //    long quantyty = long.parse(inputinarguments[2]);

            //    if (!productsquantyties.containskey(product))
            //    {
            //        productsquantyties[product] = 0;
            //        productsprices[product] = 0;
            //    }
            //    productsquantyties[product] += quantyty;
            //    productsprices[product] = price;

            //}
            //foreach (var kvp in productsprices)
            //{
            //    string name = kvp.key;
            //    decimal price = kvp.value;
            //    long quantyty = productsquantyties[name];
            //    //тук доста хитро се прави връзка между дневниците!!!
            //    decimal totalprice = quantyty * price;
            //    console.writeline($"{name} -> {totalprice:f2}");
            //}


            Dictionary<string, double> productsQuantity = new Dictionary<string, double>();
            Dictionary<string, double> productsPrices = new Dictionary<string, double>();
            Dictionary<string, double> totalProductsPrices = new Dictionary<string, double>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "buy")
                {
                    break;
                }
                string[] splitedCommand = command.Split();
                string product = splitedCommand[0];
                double price = double.Parse(splitedCommand[1]);
                double quantity = double.Parse(splitedCommand[2]);
                if (!productsQuantity.ContainsKey(product))
                {
                    productsQuantity[product] = 0;
                    productsPrices[product] = 0;
                    totalProductsPrices[product] = 0;
                }
                productsPrices[product] = price;
                productsQuantity[product] += quantity;
                totalProductsPrices[product] = productsPrices[product] * productsQuantity[product];

            }
            foreach (var product in totalProductsPrices)
            {
                Console.WriteLine($"{product.Key} -> {product.Value:f2}");
            }
        }
    }
}
