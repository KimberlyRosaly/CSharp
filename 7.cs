using System;

class Program
{
    static void Main()
    {

        // CREATE LIST
        List<string> menu = new List<string> {"one", "two", "three", "four"};
        // ASK THE USER FOR INPUT
        Console.WriteLine("TYPE ENTRY AND SUBMIT WITH [ENTER] KEY.");
        // CAPTURE USER INPUT
        string capturedInput = Console.ReadLine();
        // APPEND THE CAPTURED INPUT VALUE TO THE LIST
        menu.Add(capturedInput);
        // PRINT UPDATED LIST
        Console.WriteLine(menu);

        // ASK USER TO CHOOSE AN ENTRY TO REMOVE
        Console.WriteLine("SELECT AN ENTRY TO REMOVE. TYPE IN ENTRY TEXT, FROM LIST, AND SUBMIT WITH [ENTER] KEY.");
        // CAPTURE USER RESPONSE
        string removalCapturedInput = Console.ReadLine();
        // SEARCH LIST FOR USER RESPONSE
        menu.Contains(removalCapturedInput);
        // REMOVE SPECIFIED ENTRY ITEM FROM LIST
        menu.Remove(removalCapturedInput);
        // PRINT THE NEWLY UPDATED LIST
        Conosole.WriteLine(menu);
        

    }
}