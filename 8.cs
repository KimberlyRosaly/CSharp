using System;

class Program
{
    static void Main()
    {
        // OBJECTIVE : CREATE LOOPY LOGIC TO REQUEST DATA FROM USER

        // [x] (1), (2), (3) | [x] PROMPT USER INSTRUCTIONS | [] AWAIT AND CAPTURE USER RESPONSE

        // - - - - - - - - - - - - - - L I S T   O F   N U M B E R S
        // EMPTY, INITIALIZED LIST
        List<string> numericalList = new List<string> {};

        // 'FOR' LOOP : initialization statement, initial value : integer variable declaration 
        // (XD)micro if statement : if 'i' is 'less than' '3' : iteration statement to execute
        // post-increment operation : 'i' by '1' after each pass through the loop
        for (int i = 0; i < 3; i++)
        {
            // string interpolation signaled with: $"{variableName}"
            Console.WriteLine($"ENTER NUMERICAL VALUE <No. {i+1} of 3> AND PRESS [ENTER]");

            string userInput = Console.ReadLine();

            numericalList.Add(userInput);
        }

        // CONVERT LIST STRINGS TO INTEGERS
        // SORT VALUES WITHIN LIST
        // PRINT SORTED LIST TO CONSOLE        
        Console.WriteLine(numericalList);

    }
}