using System;

class Program
{
    static void Main()
    {
        // =====================================================
        // OBJECTIVE : CREATE MENU TO REMOVE OR ADD TO VALUES
        // =====================================================
        // ====== C OMMAND  L INE  I NTERFACE PROGRAM APPEARANCE
            /*

            D A T A   B A N K 
            (1) One | (2) Two | (3) Three | (4) 4
            Q U E R Y 
            WOULD YOU LIKE TO [REMOVE] OR [APPEND] DATA TO THIS LIST?
            [1] - APPEND | [2] - REMOVE
            I N P U T
            PLEASE, ENTER DATA BANK SELECTION TO EXECUTE FUNCTION.
            [1] - One | [2] - Two | [3] - Three | [4] - 4

            */
        // =====================================================
        // CREATE LIST OF PROMPTS
        List<str> prompts = new List<str>();
        // CREATE LIST OF EXAMPLE DATA VALUES
        List<str> sampleData = new List<str>();
        // CREATE LIST MENU OF ACTIONS 
        List<str> menu = new List<str>();
        // =====================================================

        // PRINT LIST TO CONSOLE
        Console.WriteLine(sampleData);
        // PRINT MENU OF ACTIONS
        Console.WriteLine(menu);

        // AWAIT USER INPUT
        string userInput = Console.ReadLine();

        // PERFORM REQUESTED ACTION
            // CREATE SWITCH CASE TO HANDLE CHOICE SELECTION

                // ADD VALUE TO LIST
                sampleData.Add(selection);
                // REMOVE VALUE FROM LIST
                sampleData.Remove(selection);

        // PRINT MODIFIED LIST TO CONSOLE
        Console.WriteLine(menu);
        // PRINT MENU OF ACTIONS
        Console.WriteLine(menu);

    }
}
