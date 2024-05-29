// CREATE A MENU THAT CAN CREATE DIFFERENT DATA TYPES
// ASK USER FOR INPUT
// ASK USER IF KEY AND VALUE
// ASK USER IF VALUE FOR SPECIFIED KEY
// DETECT NON-UNIQUE ENTRIES
// CREATE A USERNAME & PASSWORD & EMAIL ADDRESS


using System;

class Program
{
    static Dictionary<string, string> accounts = new Dictionary<string, string>
    {
        { "username", "email address" }
    }
    static void Main()
    {
        //GREET USER AND PROVIDE INSTRUCTIONS
        Console.WriteLine("Welcome. Please, enter your username and press [ENTER].")
        //GET USER IMPUT
        string username = Console.ReadLine();
        // SEARCH EXISTING USERNAMES FOR MATCH
        if (accounts.ContainsKey(username))
        {
            Console.WriteLine($"Hello, {username}.")
        } 
        else
        // IF NO MATCH FOUND
        {
            // INSTRUCT USER TO ENTER AN EMAIL ADDRESS TO ASSOCIATE WITH THEIR NEW USERNAME
            Console.WriteLine("Welcome, new user. Please, type in an email address to associate with your new account and press [ENTER].")
            string emailAddress = Console.ReadLine();
        }
        // CONFIRM USERNAME AND EMAIL ADDRESS WITH THE USER
        Console.WriteLine($"Please, verify your username and email address: {username} - {emailAddress}");
        Console.WriteLine("If this is correct, press [1] and the [ENTER] key. If you need to make a correction, press [2] and press [ENTER].")
        string confirmation = Console.ReadLine();
        if (confirmation == 1)
        {
            // CREATE NEW USERNAME ENTRY WITH ITS EMAIL ADDRESS
            accounts.Add(username, emailAddress);
        }
        else
        {
            // ASK USER TO INPUT A USERNAME AND EMAIL ADDRES
            // GRAB ONTO VALUES
            // CONFIRM AGAIN - MAKE A LOOP SOMEWHERE
        }
        
    }

}
