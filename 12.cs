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
        // USE CONSTANTS TO KEEP CODE MORE EASILY MAINTAINABLE BY ONLY HAVING ONE SPOT TO CHANGE | LESS PRONE TO ERRORS
        const string TYPE = "Type";
        const string FUR = "Fur";

        static void Main(string[] args)
        {
            // NESTED DICTIONARY - A DICTIONARY (KEY) THAT HAS A VALUE OF ANOTHER DICTIONARY
            // NAME = DICTIONARY KEY | DICTIONARY'S KEY'S VALUE OUTPUTS ANOTHER DICTIONARY OF KEY VALUE PAIRS
            Dictionary<string, Dictionary<string, string>> pets = new Dictionary<string, Dictionary<string, string>>()
            {
                { "Rixin", new Dictionary<string, string> { { TYPE, "Cat" }, { FUR, "Tabby" } } },
                { "Harley", new Dictionary<string, string> { { TYPE, "Cat" }, {FUR, "Black" } } },
                { "Lexy", new Dictionary<string, string> { { TYPE, "Dog" }, {FUR, "Black and Brown" } } }
            };
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 
        // ====================== CREATE MENU FOR USER TO ACCESS DICTIONARY DATA
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 

        // WELCOME USER
        Console.WriteLine(prompts["welcome"]);
        // CREATE PROMPT DICTIONARY
        Dictionary<string, string> prompts = new Dictionary<string, string>();
        // DESCRIBE PROGRAM
        // PROVIDE INSTRUCTIONS
        // AWAIT USER INPUT
        // VALIDATE USER INPUT
        // RUN DIFFERENT LOOPS DEPENDENT ON USER CHOICE
        
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 
            // =======================================COUNT ALL PETS & DISPLAY
            int petsCount = pets.Count;
            Console.WriteLine($"TOTAL NUMBER OF  P E T  ENTRIES - {petsCount}");
            // =======================================ORDER PETS BY NAME ALPHABETICALLY
            var petsByName = pets.OrderBy(pet => pet.Key);
            foreach (var pet in petsByName)
            {
                // DEFINE WHAT THE DICTIONARY KEYS ARE - AND MAKE IT ACCESSIBLE
                string name = pet.Key;
                Dictionary<string, string> petAttributes = pet.Value;
                string type = petAttributes[TYPE];
                string fur = petAttributes[FUR];

                Console.WriteLine($"P E T : NAME - {name} - PET TYPE - {type} - FUR TYPE - {fur}");
            }
            // =======================================DISPLAY ALL PETS
            foreach (var pet in pets)
            {
                string name = pet.Key;
                Dictionary<string, string> petAttributes = pet.Value;
                string type = petAttributes[TYPE];
                string fur = petAttributes[FUR];
                
                Console.WriteLine($"P E T : NAME - {name} - PET TYPE - {type} - FUR TYPE - {fur}");
            };
            // =======================================DISPLAY ALL CATS
            var cats = pets.Where(pet => pet.Value[TYPE] == "Cat");
            foreach (var cat in cats)
            {
                string name = cat.Key;
                Dictionary<string, string> catAttributes = cat.Value;
                string type = catAttributes[TYPE];
                string fur = catAttributes[FUR];

                Console.WriteLine($"P E T - C A T : NAME - {name} - PET TYPE - {type} - FUR TYPE - {fur}");
            };
            // =======================================DISPLAY ALL DOGS
            var dogs = pets.Where(pet => pet.Value[TYPE] == "Dog");
            foreach (var dog in dogs)
            {
                string name = dog.Key;
                Dictionary<string, string> dogAttributes = dog.Value;
                string type = dogAttributes[TYPE];
                string fur = dogAttributes[FUR];

                Console.WriteLine($" P E T - D O G : NAME - {name} - PET TYPE - {type} - FUR TYPE - {fur}");
            };
            // =======================================CHECK IF ANY BIRDS
            bool birds = pets.Any(pet => pet.Value[TYPE] == "Bird");
            Console.WriteLine($"P E T S - EXISTENCE OF 'BIRD' ENTRIES ? {birds}");


        }
    }
}