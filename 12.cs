using System;
using System.Collections.Generic;
// USING DIRECTIVE
using System.Linq;

        // =====================================================
        // OBJECTIVE : EXPLORE LINQ
        //      SEARCH THROUGH DATA FOR VALUE MATCHES
        // =====================================================
        // DEFINE
        //      LINQ
        //      
        // =====================================================

// KEYWORD - USED TO DEFINE A NAMESPACE
// NAMESPACE : PROVIDES SCOPE FOR IDENTIFIERS WITHIN : USED TO ORGANIZE CODE INTO LOGICAL GROUPS
namespace NamespaceExample // ANY VALID IDENTIFIER
{
    class Program
    {
        static void Main(string[] args)
        {
            // NESTED DICTIONARY - A DICTIONARY (KEY) THAT HAS A VALUE OF ANOTHER DICTIONARY
            Dictionary<string, Dictionary<string, string>> pets = new Dictionary<string, Dictionary<string, string>>()
            {
                { "Rixin", new Dictionary<string, string> { { "Type", "Cat" }, { "Fur", "Tabby" } } },
                { "Harley", new Dictionary<string, string> { { "Type", "Cat" }, {"Fur", "Black" } } },
                { "Lexy", new Dictionary<string, string> { { "Type", "Dog" }, {"Fur", "Black and Brown" } } }
            };

            // =======================================DISPLAY ALL PETS
            foreach (var pet in pets)
            {
                string name = pet.Key;
                Dictionary<string, string> petAttributes = pet.Value;
                string type = petAttributes["Type"];
                string fur = petAttributes["Fur"];
                
                Console.WriteLine($"P E T : NAME - {name} - PET TYPE - {type} - FUR TYPE - {fur}");
            };
            // =======================================DISPLAY ALL CATS
            var cats = pets.Where(pet => pet.Value["Type"] == "Cat");
            foreach (var cat in cats)
            {
                string name = cat.Key;
                Dictionary<string, string> catAttributes = cat.Value;
                string type = catAttributes["Type"];
                string fur = catAttributes["Fur"];

                Console.WriteLine($"P E T - C A T : NAME -{name} - PET TYPE - {type} - FUR TYPE - {fur}");
            };


        }
    }
}