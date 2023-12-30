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
        // CAPTURE USER RESPONSE
        // SEARCH LIST FOR USER RESPONSE
        // REMOVE SPECIFIED ENTRY ITEM FROM LIST
        // PRINT THE NEWLY UPDATED LIST
        

    }
}