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
        //              AND IS THEN SHOWN ITS DEFINITION
        // =====================================================
        // USAGES : 
        //      LIST
        //      DICTIONARY
        //      FOR EACH LOOP
        //      IF STATEMENT
        // =====================================================
        // =========================================STORE VALUES
        // INITIALIZE | DECLARE DATATYPES
        List<string> words = new List<string>();
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        Dictionary<string, string> prompts = new Dictionary<string, string>();
        // INSERT SAMPLE DATA VALUES
        words.Add("word");
        words.Add("word2");
        dictionary.Add("word", "definition");
        dictionary.Add("word2", "definition2");
        prompts.Add("welcome", "USER WELCOME MESSAGE");
        prompts.Add("instructions", "USER, PLEASE ENTER INTEGER AND PRESS [ENTER]");
        prompts.Add("error - not an integer", "ERROR - INVALID ENTRY - NOT A NUMBER - PLEASE TRY AGAIN");
        prompts.Add("error - not in range", "ERROR - INVALID ENTRY - ENTRY NOT FOUND - PLEASE TRY AGAIN");
        // =====================================================
        // =======================================DISPLAY VALUES
        int index = 1;
        foreach (var word in words)
        {
            Console.WriteLine($"[{index}] - {word}");
            index++;
        }
        // =====================================================
        // =====================================================
        // =====================================GET USER REQUEST
        // ================================CATCH ERRONEOUS INPUT
        int selectionToInteger;
        do
        {
            string selection = Console.ReadLine();
            if (!int.TryParse(selection, out selectionToInteger))
            {
                Console.WriteLine(prompts["error - not an integer"]);
            }
            else if (selectionToInteger < 1 || selectionToInteger > words.Count)
            {
                Console.WriteLine(prompts["error - not in range"]);
            }
            else
            {
                break;
            }
        } while (true);
        // =====================================================
        // ===============================DISPLAY MATCHING ENTRY 
        string selectedWord = words[selectionToInteger - 1];
        Console.WriteLine($"{selectedWord} : {dictionary[selectedWord]}");
    }
}