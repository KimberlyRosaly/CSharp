using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // =====================================================
        // OBJECTIVE : CREATE MENU TO ADD TO VALUES
        // =====================================================
        
            // CREATE LIST OF STRINGS CONTAINING PROMPTS
            List<strings> prompts = new List<strings> {"INTRODUCTION", "QUERY", "INSTRUCTIONS"};

            // CREATE LIST OF SAMPLE DATA VALUES OF STRING
            List<strings> sampleData = new List<strings> {"A", "B", "D"};

            // TELL USER ABOUT PROGRAM
            Console.WriteLine(prompts[0]);
            // DISPLAY DATA
            Console.WriteLine(string.join(" | ", sampleData));
            // ASK IF USER WOULD LIKE TO ADD A VALUE
            Console.WriteLine(prompts[1]);
            // GET USER INPUT AND STORE WITHIN VARIABLE
            string userInputConfirmation = Console.ReadLine();
            // IF USER SAYS [YES]
            if (userInputConfirmation == "YES")
            {
                //  INSTRUCT USER TO INPUT VALUE
                Console.WriteLine(prompts[2]);
                //  STORE USER RESPONSE WITHIN A VARIABLE
                string userInputValue = Console.Readline();
                // ADD NEW VALUE TO LIST
                sampleData.Add(userInputValue);
            }
                // PRINT NEW LIST TO MENU
                // LOOP BACK INTO ASKING THE USER IF THEY WANT TO ADD A VALUE
            // IF USER SAYS [NO]
                // SAY GOODBYE TO USER
                // TERMINATE PROGRAM
        
    }
}