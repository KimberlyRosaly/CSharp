using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // =====================================================
        // OBJECTIVE : CREATE LIST OF VALUES, 
        //              A WORD AND ITS DEFINITION
        //            USER SELECTS A WORD
        //              AND IS THEN SHOWN IT'S DEFINITION
        // =====================================================
        // ACHIEVE KEY-VALUE PAIRING THROUGH USE OF A DICTIONARY
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        // CREATE AN ENTRY WITH 2 VALUES {"WORD", "DEFINITION"}
        dictionary.Add("word", "definition");
        // CREATE ANOTHER OBJECT WITH 2 VALUES {"WORD2", "DEFINITION2"}
        dictionary.Add("word2", "definition2");
        // DISPLAY "1. WORD" | "2. WORD"
        int index = 1;
        foreach (var entry in dictionary)
        {
            Console.WriteLine($"{index}. {entry.Key}");
            index++;
        }
        // USER INPUTS NUMERICAL VALUE
        string userSelection = Console.ReadLine();
        // FIND MATCHING OBJECT 

            // LOOP THROUGH THE DICTIONARY
            int selectionIndex = 1;
            foreach (var entry in dictionary)
            {
                // 'TRYPARSE' WILL RETURN A BOOLEAN AND NOT THROW AN EXECEPTION ERROR
                if (int.TryParse(userSelection) == selectionIndex)
                {
                    Console.WriteLine($"{entry.Key} : {entry.Value}");
                    // RETURN STATEMENT EXITS OUT OF THE 'MAIN' FUNCTION COMPLETELY
                    // SUCCESSFUL MATCH IS DISPLAYED | FUNCTION IS RETURNED
                    return;
                }
                // INCREMENT BY 1
                selectionIndex++;
            }
            // IF LOOP DOESN'T RETURN, THE 'MAIN' FUNCTION CONTINUES ON
            // DISPLAY ERROR MESSAGE STRING TO CONSOLE
            Console.WriteLine("ERROR : MATCH WITH USER INPUT NOT FOUND");

            
                // IF THE INDEX OF THE ITERATION MATCHES THE USER'S SELECTION
                    // DISPLAY THE KEY WORD AND THE VALUE DEFINITION
                // OTHERWISE
                    // LOOP TO NEXT ENTRY UNTIL ONE IS FOUND
                // OTHERWISE THERE IS AN ERROR AND NO MATCH IS FOUND
                    // ASK USER FOR A VALID INPUT
                    // DISPLAY THE DICTIONARY CHOICES AGAIN

        // DISPLAY MATCHING OBJECT "WORD - DEFINITION" | "WORD2 - DEFINITION2"
           
        
    }
}