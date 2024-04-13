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
";    static string petDead = @"
   _ _ _ 
 /       \
|  x   X  |
 \_ _ _ _/
";
    static string hungerMeter0 = "[ ][ ][ ][ ][ ]";
    static string hungerMeter1 = "[x][ ][ ][ ][ ]";
    static string hungerMeter2 = "[x][x][ ][ ][ ]";
    static string hungerMeter3 = "[x][x][x][ ][ ]";
    static string hungerMeter4 = "[x][x][x][x][ ]";
    static string hungerMeter5 = "[x][x][x][x][x]";

    static object consoleLock = new object();

    static void Main(string[] args)
    {
        // (1) PROMPTS
        lock (consoleLock)
        {
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("WELCOME HOME!");
            Console.WriteLine("I AM YOUR PET!");
            Console.WriteLine("Please, make sure I dont get too hungry!");
        }

        // (2) HUNGER
        Task.Run(async () =>
        {
            // CREATE DEFAULT VALUE | FLAG VALUE | READ ALONE INDICES FOR METER ACCESS
            int meterIndex = 0;
            while (true)
            {
                lock (consoleLock)
                {
                    Console.SetCursorPosition(0, 6);
                    switch (meterIndex)
                    {
                        case 0:
                            Console.Write(hungerMeter0);
                            meterIndex += 1;
                            break;
                        case 1:
                            Console.Write(hungerMeter1);
                            meterIndex += 1;
                            break;
                        case 2:
                            Console.Write(hungerMeter2);
                            meterIndex += 1;
                            break;
                        case 3:
                            Console.Write(hungerMeter3);
                            meterIndex += 1;
                            break;
                        case 4:
                            Console.Write(hungerMeter4);
                            meterIndex += 1;
                            break;
                        case 5:
                            Console.Write(hungerMeter5);
                            break;
                            
                    }
                }
                await Task.Delay(2000);
            }
        });

        // (3) PET
        Task.Run(() =>
        {
            System.Timers.Timer timer = new System.Timers.Timer(1000);
            bool alive = true;
            bool breathing = false;

            timer.Elapsed += (sender, e) =>
            {
                lock (consoleLock)
                {
                    if (!alive)
                    {
                        Console.SetCursorPosition(0, 7);
                        Console.Write(petDead);
                    }
                    else
                    {
                        Console.SetCursorPosition(0, 7);
                        Console.Write(breathing ? petInhale : petExhale);
                    };
                };
                breathing = !breathing;
            };

            timer.Start();
        });

        Console.ReadLine();
    }
}
