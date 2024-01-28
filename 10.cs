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
            List<string> prompts = new List<string> {"INTRODUCTION", "QUERY", "INSTRUCTIONS", "OUTRO"};

            // CREATE LIST OF SAMPLE DATA VALUES OF STRING
            List<string> sampleData = new List<string> {"A", "B", "D"};

            // TELL USER ABOUT PROGRAM
            Console.WriteLine(prompts[0]);
            // DISPLAY DATA
            Console.WriteLine(string.Join(" | ", sampleData));
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
                string userInputValue = Console.ReadLine();
                // ADD NEW VALUE TO LIST
                sampleData.Add(userInputValue);
                // PRINT NEW LIST TO CONSOLE
                Console.WriteLine(string.Join(" | ", sampleData));
            }
            // IF USER SAYS [NO]
            else if (userInputConfirmation == "NO")
            {
                // TELL USER THE PROGRAM HAS ENDED
                Console.WriteLine(prompts[3]);
            }
            else
            {
                // DISPLAY ERROR MESSAGE
                Console.WriteLine("ERROR");
            }

            
                // LOOP BACK INTO ASKING THE USER IF THEY WANT TO ADD A VALUE
        
    }
}