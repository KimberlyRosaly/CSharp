
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
        { "new account query", "Would you like to create a new account with the username you have entered? Press [1] to confirm. Press [2] to reject. Use the [ENTER] key to proceed."},
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
    static bool AuthenticateUser(string username)
    {
        int attempts = 3;
        while (attempts > 0)
        {
            Console.WriteLine(prompts["password instructions"]);
            string passwordInput = Console.ReadLine();

            if (MatchingPassword(username, passwordInput))
            {
                // Password is correct, return true to indicate successful authentication
                return true;
            }
            else
            {
                // Password is incorrect, decrement the attempts counter and display an error message
                attempts--;
                Console.WriteLine(errors["password incorrect"])
                Console.WriteLine("You have " + attempts + " attempts remaining.");
            }
        }

        // If the user has used up all attempts, return false to indicate failed authentication
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
    static void newAccount(key, username, email, password)
    {
        accounts.Add(key, (username, email, password));
    }
    static void confirmation(credentialInput, credentialType)
    {
        /*
        Please, confirm your entry.
        CREDENTIAL TYPE : CREDENTIAL INPUT STRING INTERPOLATION
        Press [1] to confirm. Press [2] to reject. 
        Press the [ENTER] key to proceed.

            [1] C O N F I R M E D
                RETURN CONFIRMED STRING, RETURN SPECIFIED CREDENTIAL TO LINK IT TO
            [2] R E J E C T E D
                ASK USER FOR STRING FOR SPECIFIED CREDENTIAL
                Please, enter your username || password || email. Press [ENTER] to proceed.
                GRAB RESPONSE
                LOOP BACK TO THE BEGINNING OF THE FUNCTION

        => RETURN CONFIRMED ENTRY STRING
        */
    }
    static void Main()
    {
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
            if (AuthenticateUser(usernameInput))
            {
                // IF P/W MATCH WELCOME USER   
                Console.WriteLine(prompts["access granted"]);
            }
            else
            {
                // ELSE FOR P/W MATCH RETURNING FALSE
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
                int accountsCount = accounts.Count;
                // +1 TOTAL COUNT = KEY
                int newKey = accountsCount + 1;
                // ASK USER FOR EMAIL ADDRESS
                prompts["email instructions"];
                string newEmailInput = Console.ReadLine();
                // ASK USER FOR PASSWORD
                prompts["password instructions"];
                string newPasswordInput = Console.ReadLine();
                // CREATE NEW ACCOUNT WITH KEY, USERNAME, EMAIL ADDRESS, AND PASSWORD
                newAccount(newKey, usernameInput, newEmailInput, newPasswordInput);
            }
            else
            {
                // END PROGRAM
                Console.WriteLine(prompts["termination"]);
            }
            // LOOP EMAIL CONFIRM
            // LOOP P/W CONFIRM
        }
            
    }
}
