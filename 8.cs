using System;

class Program
{
    static void Main()
    {
        // OBJECTIVE : CREATE LOOPY LOGIC TO REQUEST DATA FROM USER

       

        // - - - - - - - - - - - - - - L I S T   O F   N U M B E R S
        // EMPTY, INITIALIZED LIST
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

            if(int.TryParse(userInput, out int number))
            {
                numericalList.Add(number);
            }
            else
            {
                Console.WriteLine("ERROR : VALUE IS NOT AN INTEGER : REQUESTS FOR INPUT HAVE BEEN TERMINATED")
            }
        }        
        
        // SORT VALUES WITHIN LIST
        numericalList.Sort();


        // PRINT SORTED LIST TO CONSOLE
        Console.WriteLine(string.Join(", ", numericalList));

    }
}