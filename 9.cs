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

            C O N F I R M A T I O N
            PLEASE, CONFIRM YOUR SELECTION OR DENY :
                string interpolation)
                    "REMOVE '4'"
            [Y] - CONFIRM | [N] - DENY


            IF USER SELECTS [1] - A P P E N D
                CONFIRM WITH USER - "PLEASE, CONFIRM YOUR SELECTED ACTION"
                PROMPT KEY INSTRUCTIONS - "APPEND NEW VALUE" "[Y] - CONFIRM | [N] - DENY
                
                GET INPUT - Y // N

                IF INPUT = Y - 
                    PROMPT USER - "APPEND ACTION CONFIRMED" "PLEASE, INPUT THE VALUE YOU WISH TO APPEND. TERMINATE AWAIT WITH [ENTER] KEY"
                    GET INPUT - "STRING TO COLLECT"
                    APPEND STRING - DATABANK.APPEND(INPUT)
                    PRINT MODIFIED LIST TO THE CONSOLE
                IF INPUT = N - 
                    PROMPT USER - "FURTHER ACTION DENIED"
                    END PROGRAM
           
            IF USER SELECTS [2] - R E M O V E
                CONFIRM WITH USER - "PLEASE, CONFIRM YOUR SELECTED ACTION"
                PROMPT KEY INSTRUCTIONS - "REMOVE EXISTING VALUE" "[Y] - CONFIRM | [N] - DENY"
                
                GET INPUT - Y // N

                IF INPUT = Y - 
                    PROMPT USER - "REMOVE ACTION CONFIRMED" "PLEASE, SELECT THE VALUE YOU WISH TO REMOVE. TERMINATE AWAIT WITH [ENTER] KEY"
                    GET INPUT - "STRING TO COLLECT"
                    CONVERT INPUT INTO INTEGER
                    REMOVE 1 (MATH) FROM INTEGER CONVERSION (TO PURUSE INDICE ASSOCIATION THAT BEGINS AT 0)
                    SEARCH DATABANK LIST FOR MATCHING INDICE
                    REMOVE STRING AT SPECIFIED INDEX - DATABANK.REMOVE(INPUTintoINDEX)
                    PRINT MODIFIED LIST TO THE CONSOLE 
                IF INPUT = N - 
                    PROMPT USER - "FURTHER ACTION DENIED"
                    END PROGRAM


            */
        // =====================================================
        // CREATE LIST OF PROMPTS
        List<string> prompts = new List<string> {"TITLE", "INSTRUCTIONS", "CONFIRMATION"};
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
                //  EVALUATE ARGUMENT = EXECUTE BLOCK MATCHING EVALUATION'S VALUE = 'default'ING BLOCK FOR NO MATCHES
                switch (selection)
                {
                    // WHEN THE ARGUMENT EVALUATES TO THIS VALUE, EXECUTE THE CODE BLOCK FOLLOWING
                    case 1:
                        // ADD VALUE TO LIST
                        sampleData.Add(selection);
                        // BREAK STATEMENT TO SIGNAL TERMINATION OF CODE BLOCK
                        break;
                    // WHEN THE ARGUMENT EVALUATES TO "2", EXECUTE THE CODE BLOCK FOLLOWING
                    case 2:
                        // REMOVE VALUE FROM LIST
                        sampleData.Remove(selection);
                        break;
                    default:
                    // PRINT TO THE CONSOLE THE STRING ARGUMENT
                        Console.WriteLine("ERROR : INVALID INPUT");
                        break;
                }
            // =============================================
        }

        // PRINT MODIFIED LIST TO CONSOLE
        Console.WriteLine("DATA : " + string.Join(" | ", sampleData));
        // PRINT MENU OF ACTIONS
        Console.WriteLine("MENU : " + string.Join(" | ", menu));

    }
}
