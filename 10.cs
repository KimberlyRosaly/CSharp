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
            List<string> prompts = new List<string> {"WELCOME! VIEW A LIST OF DATA & CHOOSE TO APPEND A STRING VALUE OF YOUR DESIGN!", "WOULD YOU LIKE TO APPEND A VALUE?", "PLEASE, ENTER 'YES' OR 'NO'.", "THANK YOU & GOODBYE!"};

            // CREATE LIST OF SAMPLE DATA VALUES OF STRING
            List<string> sampleData = new List<string> {"A", "B", "D"};

            // TELL USER ABOUT PROGRAM
            Console.WriteLine(prompts[0]);
            // DISPLAY DATA
            Console.WriteLine(string.Join(" | ", sampleData));

            // LOOP CONSTRUCT : BOOLEAN LITERAL
            // EXECUTE BLOCK OF CODE AS LONG AS CONDITION LISTED BETWEEN PARENTHESIS REMAINS TRUE
            // 'true' WILL EXECUTE INDEFINITELY UNTIL EXPLICITLY BROKEN - AKA 'break;' STATEMENT
            while (true)
            {
                // ASK IF USER WOULD LIKE TO ADD A VALUE
                Console.WriteLine(prompts[1]);
                // GET USER INPUT AND STORE WITHIN VARIABLE | REGARDLESS OF CASING, STRING IS CAPITALIZED FOR EASIER COMPARISONS
                string userInputConfirmation = Console.ReadLine().ToUpper();
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
                    // EXIT THIS LOOP
                    break;
                }
                // IF THERE IS AN INVALID INPUT
                else
                {
                    // DISPLAY AN USER INPUT ERROR MESSAGE
                    Console.WriteLine("PLEASE TYPE IN 'YES' OR 'NO'. ALL OTHER INPUT IS INVALID. PLEASE, TRY AGAIN.");
                    // GIVE THE USER INSTRUCTIONS AGAIN
                    Console.WriteLine(prompts[0]);
                }
            }

            
                // LOOP BACK INTO ASKING THE USER IF THEY WANT TO ADD A VALUE
        
    }
}