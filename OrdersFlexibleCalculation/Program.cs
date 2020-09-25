using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пример с вложено Dictionary на задача Orders
            Dictionary<string, Dictionary<decimal, long>> products = new Dictionary<string, Dictionary<decimal, long>>();
            products["Beer"].Sum(kvp => kvp.Key * kvp.Value);

        }
    }
}
