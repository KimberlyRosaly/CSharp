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

        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 
        // ===================== METHODS FOR GRABBING ONTO DATA IN SPECIFIC WAYS
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 
        static void PetsCount()
        {
            // =======================================COUNT ALL PETS & DISPLAY
            int petsCount = pets.Count;
            Console.WriteLine($"TOTAL NUMBER OF  P E T  ENTRIES - {petsCount}");
        };

        static void PetsIndex()
        {
            // ===============================================DISPLAY ALL PETS
            foreach (var pet in pets)
            {
                string name = pet.Key;
                Dictionary<string, string> petAttributes = pet.Value;
                string type = petAttributes[TYPE];
                string fur = petAttributes[FUR];
                
                Console.WriteLine($"P E T : NAME - {name} - PET TYPE - {type} - FUR TYPE - {fur}");
            }
        };

        static void CatsDisplay()
        {
            // ================================================DISPLAY ALL CATS
            var cats = pets.Where(pet => pet.Value[TYPE] == "Cat");
            foreach (var cat in cats)
            {
                string name = cat.Key;
                Dictionary<string, string> catAttributes = cat.Value;
                string type = catAttributes[TYPE];
                string fur = catAttributes[FUR];

                Console.WriteLine($"P E T - C A T : NAME - {name} - PET TYPE - {type} - FUR TYPE - {fur}");
            };            
        };

        static void DogsDisplay()
        {
            // ================================================DISPLAY ALL DOGS
            var dogs = pets.Where(pet => pet.Value[TYPE] == "Dog");
            foreach (var dog in dogs)
            {
                string name = dog.Key;
                Dictionary<string, string> dogAttributes = dog.Value;
                string type = dogAttributes[TYPE];
                string fur = dogAttributes[FUR];

                Console.WriteLine($" P E T - D O G : NAME - {name} - PET TYPE - {type} - FUR TYPE - {fur}");
            };
        };

        static void BirdsCheck()
        {
            // ==============================================CHECK IF ANY BIRDS
            bool birds = pets.Any(pet => pet.Value[TYPE] == "Bird");
            Console.WriteLine($"P E T S - EXISTENCE OF 'BIRD' ENTRIES ? {birds}");
        };

        static void PetsByName()
        {
            // ================================ORDER PETS BY NAME ALPHABETICALLY
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

        };
        
        static void Main(string[] args)
        {
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 
        // ======================= DICTIONARIES TO HOLD DATA TO DISPLAY LATER ON
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 
            // NESTED DICTIONARY - A DICTIONARY (KEY) THAT HAS A VALUE OF ANOTHER DICTIONARY
            // NAME = DICTIONARY KEY | DICTIONARY'S KEY'S VALUE OUTPUTS ANOTHER DICTIONARY OF KEY VALUE PAIRS
            Dictionary<string, Dictionary<string, string>> pets = new Dictionary<string, Dictionary<string, string>>()
            {
                { "Rixin", new Dictionary<string, string> { { TYPE, "Cat" }, { FUR, "Tabby" } } },
                { "Harley", new Dictionary<string, string> { { TYPE, "Cat" }, {FUR, "Black" } } },
                { "Lexy", new Dictionary<string, string> { { TYPE, "Dog" }, {FUR, "Black and Brown" } } }
            };
            // PROMPTS
            Dictionary<string, string> prompts = new Dictionary<string, string>()
            {
                { "welcome message", "WELCOME, USER!" },
                { "program description", "THIS PROGRAM WILL LIST PETS AND THEIR INFORMATION FROM WITHIN A DICTIONARY DATABASE."},
                { "user instructions", "PLEASE, SELECT AN OPTION FROM THE MENU, INPUTTING THE INTEGER, THEN PRESSING [ENTER] ON YOUR KEYBOARD."}
            };
            // MENU - LIST OF USER ACTIONS
            Dictionary<string, string> menu = new Dictionary<string, string>
            {
                { "options", 
                    string.Join("\n", @"
                    [1] - DISPLAY TOTAL NUMBER COUNT OF ALL PET ENTRIES IN DATABASE
                    [2] - DISPLAY ALL PET ENTRIES
                    [3] - DISPLAY ALL CAT ENTRIES
                    [4] - DISPLAY ALL DOG ENTRIES
                    [5] - CHECK IF ANY BIRDS EXIST IN DATABASE".Split('\n').Select(line => line.Trim()))
                }
            };

            // ERROR MESSAGES
            Dictionary<string, string> errors = new Dictionary<string, string>()
            {
                { "invalid input", "ERROR: INVALID ENTRY! NUMERICAL INPUT REQUIRED!" },
                { "input not in range", "ERROR: INVALID ENTRY! NUMERICAL INPUT NOT WITHIN MENU RANGE!" }
            };
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 
        // ================================== OUTPUT TO CONSOLE | ACTUAL PROGRAM
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 
        // WELCOME USER
        Console.WriteLine(prompts["welcome message"]);
        // DESCRIBE PROGRAM
        Console.WriteLine(prompts["program description"]);
        // PROVIDE INSTRUCTIONS
        Console.WriteLine(prompts["user instructions"]);
        // DISPLAY NUMBERED MENU OF ACTIONS
        Console.WriteLine(menu["options"]);
        // AWAIT USER INPUT
        string userInput = Console.ReadLine();
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 
        // VALIDATE USER INPUT
        int userInputToNumber;
        bool userInputToNumberSuccess = int.TryParse(userInput, out userInputToNumber);
        // RUN DIFFERENT LOOPS DEPENDENT ON USER CHOICE
        // CREATE A SWITCH STATEMENT TO HANDLE USER'S DESIRED OUTPUT
        if (userInputToNumberSuccess)
        {
            case 1:
                // COUNT PETS METHOD
                PetsCount();
                break;
            case 2:
                // DISPLAY ALL PETS
                PetsIndex();
                break;
            case 3:
                // DISPLAY CATS METHOD
                CatsDisplay();
                break;
            case 4:
                // DISPLAY DOGS METHOD
                DogsDisplay();
                break;
            case 5:
                // END THE PROGRAM
                break;
            default:
                // ERROR MESSAGE - IF THE USER INPUT IS NOT ON THE MENU'S NUMBER RANGE
                Console.WriteLine(errors["input not in range"]);
                break;
        }
        
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 



        }
    }
}