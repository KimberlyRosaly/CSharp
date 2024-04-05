using System;
// ALLOW MULTITHREADING
using System.Threading.Tasks;

class Program
{
    static string petInhale = @"
  _ _ _ 
/       \
| -   - |
\_ _ _ _/
";
    static string petExhale = @"
   _ _ _ 
 /       \
|  -   -  |
 \_ _ _ _/
";

    static void Main(string[] args)
    {
        // ENCAPSULATED WILL RUN ON ITS OWN THREAD > SEPERATE AND ABLE TO RUN CONCURRENTLY
        Task.Run(() =>
        {
            // INITIALIZE A TIMER TO BE TRIGGERED EVERY 1 SECOND
            // CLASS | STORED REFERENCE | INITIALIZATION OF INSTANCE | ARGUMENT FOR CONSTRUCTOR
            System.Timers.Timer timer = new System.Timers.Timer(1000);
            // TOGGLE FRAMES WITH BOOLEAN AND SET IT'S DEFAULT VALUE TO BE FALSEY
            bool toggle = false;

            // SET TO ADD > THEN REDEFINE > PASS IN EVENT HANDLER
            timer.Elapsed += (sender, e) =>
            {
                // CLEAR CONSOLE FOR A BLANK SLATE TO WORK WITH
                Console.Clear();
                // TERNARY - IF TOGGLE IS TRUTHY, DISPLAY LARGER FRAME, OTHERWISE DISPLAY SMALLER FRAME
                Console.WriteLine(toggle ? petInhale : petExhale);
                // REDEFINE VARIABLE TO THE OPPOSITE OF WHAT IT CURRENTLY IS
                toggle = !toggle;
            };

            // BEGIN THE TIMER
            timer.Start();
            // TIMER RUNS INFINITELY
            while (true) { }
        });

        Console.WriteLine("HELLO, USER!");
    }
}