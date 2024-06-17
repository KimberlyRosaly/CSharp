
/*
DICTIONARIES
    [] -PROMPTS
    [x] -USER DATA => ACCOUNT { ENTRY-INTEGER, "USERNAME", "EMAIL", "PASSWORD" }
    [] -ERROR MESSAGES
    
[] (1) GREET USER
[] (2) PROVIDE INSTRUCTIONS
[X] (3) AWAIT USER INPUT (USERNAME)
[X] (4) GRAB ONTO USER INPUT (USERNAME)
[X] (5) SEARCH DICTIONARY > FIND MATCHING USERNAME > ACCOUNT ENTRY
    IF ACCOUNT ENTRY FOUND =>
        [] (6) PROVIDE INSTRUCTIONS
        [] (7) AWAIT USER INPUT (PASSWORD)
        [] (8) GRAB ONTO USER INPUT (PASSWORD)
        [] (9) COMPARE [PASSWORD INPUT] WITH (ACCOUNT PASSWORD)
            IF PASSWORDS MATCH =>
                [] (10) PROMPT USER > ACCOUNT ACCESS GRANTED
            IF PASSWORDS DO NOT MATCH =>
                [] (10) PROMPT USER > ACCOUNT ACCESS DENIED
    IF ACCOUNT ENTRY NOT FOUND => 
        [] (6) PROVIDE INSTRUCTIONS
        [] (7) AWAIT USER INPUT (CREATE NEW ACCOUNT ENTRY)
        [] (8) GRAB ONTO USER INPUT (CREATE NEW ACCOUNT ENTRY)
            IF USER CONFIRMS (CREATE NEW ACCOUNT ENTRY) =>
                [] (9) GENERATE (ACCOUNT)
                [] (10) GRAB ONTO (ACCOUNT)
                [] (11) GENERATE (KEY)
                [] (12) ADD (KEY) TO (ACCOUNT)
                [] (13) ADD (USERNAME) TO (ACCOUNT)
                [] (14) PROVIDE INSTRUCTIONS (CREATE NEW EMAIL)
                [] (15) AWAIT USER INPUT (CREATE NEW EMAIL)
                [] (16) GRAB ONTO USER INPUT (CREATE NEW EMAIL)
                [] (17) ADD (EMAIL) TO (ACCOUNT)
                [] (18) PROVIDE INSTRUCTIONS (CREATE NEW PASSWORD)
                [] (19) AWAIT USER INPUT (CREATE NEW PASSWORD)
                [] (20) GRAB ONTO USER INPUT (CREATE NEW PASSWORD)
                [] (21) ADD (PASSWORD) TO (ACCOUNT)
                [] (22) PROMPT USER > ACCOUNT CREATION SUCCESS
            IF USER DENIES (CREATE NEW ACCOUNT ENTRY) =>
                [] (9) PROMPT USER > PROGRAM TERMINATING

POTENTIAL LOOPS                
    -CONFIRMATION DIALOGS (ARE YOU SURE?)
    -PASSWORD MATCH FAIL (PLEASE, TRY AGAIN)
    -USERNAME ALREADY EXISTS (PLEASE, TRY AGAIN)
    -PASSWORD CREATION REJECTION (PLEASE, TRY AGAIN)
POTENTIAL REUSABLE FUNCTIONS
    -AWAITING INPUT & GRABBING AHOLD (VARIABLE STORAGE)
    -ACCOUNT LOOKUP (ACCOUNTS SEARCH)
*/

using System;

class Program
{
    // ========================================================DICTIONARIES=
    static Dictionary<string, string> prompts = new Dictionary<string, string>
    {
        { "greeting", "Welcome, user!" },
        { "description", "Access your account or create a new one."},
        { "username instructions", "Please, enter your username and press [ENTER]." },
        { "password instructions", "Please, enter your password and press [ENTER]." },
        { "email instructions", "Please, enter your email address and press [ENTER]." },
        { "access granted", "Your password has been accepted. Access has been granted to your account. Welcome!" },
        { "confirmation", "Please, confirm your entries. If the following is correct, press [1]. If you need to make changes, press [2]. Press [ENTER] to proceed." },
        { "new account query", "Would you like to create a new account with the username you have entered?"},
        { "termination", "Thank you for using this program. Goodbye." }
    };
    static Dictionary<string, string> errors = new Dictionary<string, string>
    {
        { "password incorrect", "The password you have entered is incorrect. Please, try again."},
        { "password invalid", "The password you have entered is invalid. Input must be an alphanumerical value. Please, try again."},
        { "username does not exist", "The username you have entered is not a currently existing account."},
        { "username prexisting", "The username you have entered has already been taken. Please, try again."},

    };
    // =====================================================================
    /*
    static Dictionary<string, string> accounts = new Dictionary<string, string>
    {
        { "username", "email address" }
    };
    */
    // =====================================================================
    // ----------------------------------------------T U P L E || VALUETUPLE
    // =====================================================================
    static Dictionary<int, (string, string, string)> accounts = new Dictionary<int, (string, string, string)>
    {
        { 1, ("username", "email@ddress", "password") }
    };
    // =====================================================================
    // BOOLEAN THAT RETURNS TRUE IF A HANDED IN ARGUMENT
    //   OF A STRING EXISTS AS THE FIRST VALUE PRESENT IN A TUPLE DICTIONARY
    static bool ExistingUsername(string username)
    {
        // ITERATE THROUGH THE ACCOUNTS DICTIONARY, EACH OBJECT ENTRY REFERRED TO AS 'account'
        foreach (var account in accounts)
        {
            //  COMPARE THE ITERATED SINGULAR ACCOUNT OBJECT'S 1ST VALUE WITH THE FUNCTION'S STRING PARAMETER
            if (account.Value.Item1 == username)
            {
                // RETURN A TRUTHY VALUE IF A MATCH BETWEEN STRINGS OCCURS
                return true;
            }
        }
        // AFTER THE ITERATING IS COMPLETE, RETURN FALSEY SINCE NO MATCHES HAD BEEN FOUND
        return false;
    }
    static bool MatchingPassword(username, password)
    {
        foreach (var account in accounts)
        {
            if (account.Value.Item1 == username)
            {
                if (account.Value.Item3 == password)
                {
                    return true;
                }
            }
        }
        return false;
    }
    static bool ExistingUsernameOrEmail(string username, string email)
    {
        // CHECK IF USERNAME AND EMAIL ADDRESS ENTRIES EXIST IN DICTIONARIES
        if (accounts.ContainsKey(username) || accounts.ContainsValue(email))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void addUsernameAndEmail(username, email)
    {
        accounts.Add(username, email);
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
        int confirmationToInteger = int.Parse(confirmation);
        if (confirmationToInteger == 1)
        {
            // CREATE NEW USERNAME ENTRY WITH ITS EMAIL ADDRESS
            accounts.Add(username, emailAddress);
        }
        else
        {
            // ASK USER TO INPUT A USERNAME AND EMAIL ADDRESS
            Console.WriteLine("Please, enter username and press [ENTER]")
            string un = Console.ReadLine();
            Console.WriteLine("Please, enter your email address and press [ENTER]")
            string em = Console.ReadLine();
            // GRAB ONTO VALUES
            string emailAddress = Console.ReadLine();
            // CONFIRM AGAIN - MAKE A LOOP SOMEWHERE
        }
        
    }
    // GREETING
    Console.WriteLine(prompts["greeting"]);
    //INSTRUCTIONS
    Console.WriteLine(prompts["description"]);
    Console.WriteLine(prompts["username instructions"]);
    // AWAIT U/N'
    string usernameInput = Console.ReadLine();
    // CHECK MATCH
    if (ExistingUsername(usernameInput))
    {
        // IF MATCH ASK P/W
        Console.WriteLine(prompts["password instructions"])
        string passwordInput = Console.ReadLine();
        if (MatchingPassword(usernameInput, passwordInput))
        {
            // IF P/W MATCH WELCOME USER   
            Console.WriteLine(prompts["access granted"]);
        }
        else
        {
            // ELSE [TODO: LOOP IN THE FUTURE] FOR P/W MATCH RETURNING FALSE
            Console.WriteLine(errors["password incorrect"]);
            Console.WriteLine(prompts["termination"]);
        }
    }
    else
    {
        // ELSE CREATE NEW 
        Console.WriteLine(errors["username does not exist"]);
        Console.WriteLine(prompts["new account query"]);
        string confirmationInput = Console.ReadLine();
        // LOOP U/N CONFIRM
        if (confirmationInput == "1")
        {
            // COUNT ENTRIES IN ACCOUNTS FOR KEY
            // +1 TOTAL COUNT = KEY
            // ASK USER FOR EMAIL ADDRESS
            // ASK USER FOR PASSWORD
            // CREATE NEW ACCOUNT WITH KEY, USERNAME, EMAIL ADDRESS, AND PASSWORD
        }
        else
        {
            // END PROGRAM
        }
        // LOOP EMAIL CONFIRM
        // LOOP P/W CONFIRM
    }
        

}
