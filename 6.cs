using System;

class Program
{
    static void Main()
    {
        // V A R I A B L E S
        // name a list of strings 'options'
        // create a new instance object containing strings
        List<string> options = new List<string> {"(a)", "(b)"};
        // create array : assign variable : contain an object of strings
        string[] menuOptions = { "Option 1", "Option 2", "Option 3", "Exit" };

        // P R I N T
        // Display instructions to user
        // print string to console
        Console.WriteLine("Please, type in your selection and press the [ENTER] key: ");

        // L O O P
        // initialization statement
        // expression to check : condition
        // expression to evaluate if check returns true
        for (int i = 0; i < options.Count; i++)
        {
            // print to console looped string interpolation
            Console.WriteLine($"{options[i]}");
        }

        // C A P T U R E
        // contain user input within a variable
        string userInput = Console.ReadLine();

    }
}