using System;
using System.Collections.Generic;
// USING DIRECTIVE
using System.Linq; // FOR SEARCHY THINGS
using System.Globalization; // FOR TEXTY & TITLECASING THINGS

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
        // ======================= DICTIONARIES TO HOLD DATA TO DISPLAY LATER ON
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 
        // 'static' > KEYWORD > MEMBER BELONGS TO CLASS & SHARED AMONG ALL INSTANCES
        // NESTED DICTIONARY - A DICTIONARY (KEY) THAT HAS A VALUE OF ANOTHER DICTIONARY
        // NAME = DICTIONARY KEY | DICTIONARY'S KEY'S VALUE OUTPUTS ANOTHER DICTIONARY OF KEY VALUE PAIRS
        static Dictionary<string, Dictionary<string, string>> pets = new Dictionary<string, Dictionary<string, string>>()
        {
            { "Rixin", new Dictionary<string, string> { { TYPE, "Cat" }, { FUR, "Tabby" } } },
            { "Harley", new Dictionary<string, string> { { TYPE, "Cat" }, {FUR, "Black" } } },
            { "Lexy", new Dictionary<string, string> { { TYPE, "Dog" }, {FUR, "Black and Brown" } } }
         };
        // PROMPTS
        static Dictionary<string, string> prompts = new Dictionary<string, string>()
        {
            { "welcome message", "WELCOME, USER!" },
            { "program description", "THIS PROGRAM WILL LIST PETS AND THEIR INFORMATION FROM WITHIN A DICTIONARY DATABASE."},
            { "user instructions", "PLEASE, SELECT AN OPTION FROM THE MENU, INPUTTING THE INTEGER, THEN PRESSING [ENTER] ON YOUR KEYBOARD."}
        };
        // MENU - LIST OF USER ACTIONS > MULTILINE STRING
        //  USE NEW LINES AND VERBATIM STRING LITERAL WITH WHITESPACE TRIMMING > FOR CODE READABILITY
        static Dictionary<string, string> menu = new Dictionary<string, string>
        {
            { "options", 
                string.Join("\n", @"
                    [1] - DISPLAY TOTAL NUMBER COUNT OF ALL PET ENTRIES IN DATABASE
                    [2] - DISPLAY ALL PET ENTRIES
                    [3] - DISPLAY ALL CAT ENTRIES
                    [4] - DISPLAY ALL DOG ENTRIES
                    [5] - CHECK IF ANY BIRDS EXIST IN DATABASE
                    [6] - REQUEST CUSTOM SPECIES CHECK IN DATABASE
                    [7] - E X I T  P R O G R A M".Split('\n').Select(line => line.Trim()))
            }
        };
        // ERROR MESSAGES
        static Dictionary<string, string> errors = new Dictionary<string, string>()
        {
            { "invalid input", "ERROR: INVALID ENTRY! NUMERICAL INPUT REQUIRED!" },
            { "input not in range", "ERROR: INVALID ENTRY! NUMERICAL INPUT NOT WITHIN MENU RANGE!" }
        };
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 
        // ===================== METHODS FOR GRABBING ONTO DATA IN SPECIFIC WAYS
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 
        static void PetsCount()
        {
            // =======================================COUNT ALL PETS & DISPLAY
            int petsCount = pets.Count;
            Console.WriteLine($"TOTAL NUMBER OF  P E T  ENTRIES - {petsCount}");
        }

        static void PetsIndex()
        {
            // ===============================================DISPLAY ALL PETS
            // =========================================BY NAME ALPHABETICALLY
           PetsByName();
        }

        static void PetsFindAndDisplay(string petType)
        {
            var petsOfType = pets.Where(pet => pet.Value[TYPE] == petType);
            foreach (var pet in petsOfType)
            {
                string name = pet.Key;
                Dictionary<string, string> petAttributes = pet.Value;
                string type = petAttributes[TYPE];
                string fur = petAttributes[FUR];
                Console.WriteLine($"P E T - {petType.ToUpper()} : NAME - {name} - PET TYPE - {type} - FUR TYPE - {fur}");
            }
        }

        static void BirdsCheck()
        {
            // ==============================================CHECK IF ANY BIRDS
            bool birds = pets.Any(pet => pet.Value[TYPE] == "Bird");
            Console.WriteLine($"P E T S - EXISTENCE OF 'BIRD' ENTRIES ? {birds}");
        }

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

        }

        static void PetsSearch(string userInputSpecies)
        {
            // "NORMALIZE" INPUT AND SAVE
            // INITIALIZE IMPORTED FUNCTIONALITY FOLLOWING CONVENTIONS - 
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            // CAPITALIZE FIRST CHARACTER + SAVE
            string userInputSpeciesNormalized = textInfo.ToTitleCase(userInputSpecies.ToLower());
            // SEARCH THROUGH PETS 'TYPE' TO FIND MATCHING STRING USING LINQ
            var speciesFound = pets.Where(pet => pet.Value[TYPE] == userInputSpeciesNormalized);
            // IF INPUT IS NOT FOUND - RETURN BOOLEAN = FALSE | "NO MATCHING ENTRIES FOUND"
            if (speciesFound.Any())
            {
                Console.WriteLine($"P E T S - EXISTENCE OF '{userInputSpecies}' ENTRIES ? {speciesFound.Any()}");
                PetsFindAndDisplay(userInputSpeciesNormalized);
            }
            else
            {  
                Console.WriteLine(" SORRY - NO MATCHING PETS OF THAT SPECIES FOUND");
            }
        }
        // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
        // -*_*_*_*_*_*B E G I N   A C T U A L   C O D E*_*_*_*_*_*_*_*_*_*_*_*_
        // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
        static void Main(string[] args)
        {
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 
        // ================================== OUTPUT TO CONSOLE | P R O G R A M
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 
        // WELCOME USER
        Console.WriteLine(prompts["welcome message"]);
        // DESCRIBE PROGRAM
        Console.WriteLine(prompts["program description"]);
        // PROVIDE INSTRUCTIONS
        Console.WriteLine(prompts["user instructions"]);
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 
        // =========================================================DISPLAY MENU
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 
        // BEGIN A LOOP TO DISPLAY THE MENU, ALLOW USER TO MAKE A SELECTION, OUTPUT ACCORDINGLY, THEN BEGIN AGAIN
        // BOOLEAN - FLAG - RUNNING THE PROGRAM STAYS TRUE UNTIL VARIABLE IS REDEFINED TO FALSEY VALUE
        bool runMenuLoop = true;
        while (runMenuLoop)
        {
            // DISPLAY NUMBERED MENU OF ACTIONS
            Console.WriteLine(menu["options"]);
            // AWAIT USER INPUT
            string userInput = Console.ReadLine();
            // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 
            // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 
            // VALIDATE USER INPUT
            // DECLARE AN INTEGER VARIABLE THAT SHOULD STORE THE USER'S INPUT AS A NUMBER
            int userInputToNumber;
            // INITIALIZE A BOOLEAN TO RUN TRUE OR FALSE - IF THE USER'S STRING INPUT CAN BE PARSED AND OUTPUTTED INTO A NUMBER
            bool userInputToNumberSuccess = int.TryParse(userInput, out userInputToNumber);
            // RUN DIFFERENT LOOPS DEPENDENT ON USER CHOICE
            // CREATE A SWITCH STATEMENT TO HANDLE USER'S DESIRED OUTPUT
            // IF THE USER'S STRING INPUT CAN BE CONVERTED INTO AN INTEGER > TRUE
            if (userInputToNumberSuccess)
            {
                switch (userInputToNumber)
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
                        PetsFindAndDisplay("Cat");
                        break;
                    case 4:
                        // DISPLAY DOGS METHOD
                        PetsFindAndDisplay("Dog");
                        break;
                    case 5:
                        // CHECK IF BIRDS EXIST IN DATABASE
                        BirdsCheck();
                        break;
                    case 6:
                        // ==========================================
                        // ALLOW USER TO CHECK FOR ANY PET TYPE
                        Console.WriteLine("ENTER A SPECIES TO QUERY DATABASE - THEN PRESS THE [ENTER] KEY");
                        // (3) AWAIT USER INPUT  (4) SAVE USER INPUT
                        string userInputSpecies = Console.ReadLine();
                        // IF INPUT IS FOUND - PARSE AND INTERPOLATE DATA - DISPLAY RESULTS TO CONSOLE
                        PetsSearch(userInputSpecies);                   
                        break;
                    case 7:
                        // END THE PROGRAM
                        Console.WriteLine("YOU HAVE CHOSEN TO EXIT THE PROGRAM - G O O D B Y E !");
                        runMenuLoop = false;
                        break;
                    default:
                        // ERROR MESSAGE - IF THE USER INPUT IS NOT ON THE MENU'S NUMBER RANGE
                        Console.WriteLine(errors["input not in range"]);
                        break;
                }
            }
        }
        
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 



        }
    }
}