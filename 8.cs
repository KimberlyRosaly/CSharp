using System;

class Program
{
    static void Main()
    {
        // OBJECTIVE : CREATE LOOPY LOGIC TO REQUEST DATA FROM USER

       

        // - - - - - - - - - - - - - - L I S T   O F   N U M B E R S
        // EMPTY, INITIALIZED LIST : INSTANCE OF 'list<T>' CLASS
        List<int> numericalList = new List<int> {};

        // - - - - - - - - - - - - - - l O O P  3  T I M E S - - - -
        // 'FOR' LOOP : initialization statement, initial value : integer variable declaration 
        // (XD)micro if statement : if 'i' is 'less than' '3' : iteration statement to execute
        // post-increment operation : 'i' by '1' after each pass through the loop
        for (int i = 0; i < 3; i++)
        {
            // string interpolation signaled with: $"{variableName}" syntax
            Console.WriteLine($"ENTER NUMERICAL VALUE <No. {i+1} of 3> AND PRESS [ENTER]");
            // capture user input as a string
            string userInput = Console.ReadLine();

            // 'System' NAMESPACE ACCESS TO 'int.TryParse'
            // 2 PARAMETERS (STRING TO CONVERT, 'out' KEYWORD 
            // PARAMETER TO HOLD SUCCESSFUL 'int'EGER CONVERSION 
            // PASSED IN WITH ARBITRARY VARIABLE DECLARATION REFERENCE 'number'
            // STORES THE RESULT OF CONVERSION
            if(int.TryParse(userInput, out int number))
            {
                // SYSTEM NAMESPACE METHOD PROVIDED BY 'List<T>' CLASS
                // ADD ELEMENT TO THE END OF THE 'list<T>'
                numericalList.Add(number);
            }
            else
            {
                Console.WriteLine("ERROR : VALUE IS NOT AN INTEGER")
            }
        }        
        
        // SORT VALUES WITHIN LIST - ASCENDING ORDER
        numericalList.Sort();


        // PRINT SORTED LIST TO CONSOLE IN SINGLE LINE WITH COMMA SEPERATED VALUES
        Console.WriteLine(string.Join(", ", numericalList));

    }
}