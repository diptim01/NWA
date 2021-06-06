using Country.Services;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace Country
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> towns = new StreamLookOut().ReadText($"{System.IO.Directory.GetCurrentDirectory()}\\Towns\\CanadaTowns.txt");

            ProcessEntries(towns, "Yukon");
        }

        private static void ProcessEntries(List<string> towns, string city)
        {
            foreach (var item in towns)
            {

                new DbCall(ConfigurationManager.ConnectionStrings["BusinessListing"].ConnectionString).InsertEntries(item, city);
            }
        }
    }
}
