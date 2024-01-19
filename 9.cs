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
        List<string> prompts = new List<string> {"TITLE", "INSTRUCTIONS", "DIRECTIONS"};
        // CREATE LIST OF EXAMPLE DATA VALUES
        List<string> sampleData = new List<string> {"One", "Two", "Three", "4"};
        // CREATE LIST MENU OF ACTIONS 
        List<string> menu = new List<string> {"ADD VALUE", "REMOVE VALUE"};
        // =====================================================

        // PRINT LIST TO CONSOLE
        Console.WriteLine("DATA : " + string.Join(" | ", sampleData));
        // PRINT MENU OF ACTIONS
        Console.WriteLine("MENU : " + string.Join(" | ", menu));

        // AWAIT USER INPUT
        string userInput = Console.ReadLine();

        // if user input can be parsed into an integer, it will become the 'selection' data
        if (int.TryParse(userInput, out int selection))
        {

        // PERFORM REQUESTED ACTION
            // CREATE SWITCH CASE TO HANDLE CHOICE SELECTION
            // =============================================
                switch (selection)
                {
                    case 1:
                        // ADD VALUE TO LIST
                        sampleData.Add(selection);
                        break;
                    case 2:
                        // REMOVE VALUE FROM LIST
                        sampleData.Remove(selection);
                        break;
                    default:
                        break;
                }
            // =============================================
        }

        // PRINT MODIFIED LIST TO CONSOLE
        Console.WriteLine(menu);
        // PRINT MENU OF ACTIONS
        Console.WriteLine(menu);

    }
}
