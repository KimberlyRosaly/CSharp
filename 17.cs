// Create a dialog with a user
// Show the user cute ASCII artwork for each prompt
// Be as artistic as possible and conversational

// Greet the user
// Ask the user their name
// Store the user's name and refer back to them in each prompt

// Create a bit of a roleplaying scenario
// Test out some gaming possibilities / concepts


// RP CONCEPT - grow a garden
// Be able to keep track of days that the user visits - grab onto the current date and time
// Each day that the user uses the application, increase the growth of a plant
// Day 1: seed - user plants the seed
// Day 2: seedling - seed has germinated and begins to sprout
// Day 3: bud - a bit of a vine appears with a small leaf
// Day 4: stem & leaves - plant is able to stand and has several leaves appearing
// Day 5: full fledged plant

// IDEA : HORROR GAME - PLANT SPROUTS STRANGE EXTREMETIES - EYEBALLS, MOUTHS, TEETH, CLAWS, DEVIL TAILS
// STRETCH GOAL : EXTREMETIES MOVE - EYEBALLS BLINK, MOUTHS SMILE, TEETH GLEAMS, CLAWS WAVE, TAILS WAG

string gameTitle = @"
  __    _,   ___,  _    ,  ,  ___,   _,  _     ,     
 '|_)  / \, ' |   '|\   |\ | ' |    /   '|\    |     
 _|_) '\_/    |    |-\  |'\|  _|_, '\_   |-\  '|__   
'      '      '    '  ` '  ` '        `  '  `    '   
                                                     
   |      _,   ,  ,  _     ,_     ,_   ___,  _    ,  , 
  \|/    / _   |  | '|\    |_)    | \,' |   '|\   |\ | 
 \\|//  '\_|` '\__|  |-\  '| \   _|_/  _|_,  |-\  |'\| 
 \ - /    _|      `  '  `  '  ` '     '      '  ` '  ` 
         '                                             
";

string accessGrantedArt = @"
 ______________________________
|                              |
|  A C C E S S  G R A N T E D  |
|______________________________|
";
string accessDeniedArt = @"
 ______________________________
|                              |
|   A C C E S S  D E N I E D   |
|______________________________|
";
string thirstArt = @"
 _________________
|                 |
|   T H I R S T   |
|_________________|
";
string hungerArt = @"
 _________________
|                 |
|   H U N G E R   |
|_________________|
";

{
    {"title", "Botanical Guardian"},
    {"", "A roleplaying game & garden simulator"},

    {"", "Please, type in your username and press the [ENTER] key."},
    {"", "Please, type in your password and press the [ENTER] key."},
    {"", "ACCESS DENIED"},
    {"", "ACCESS GRANTED"},

    {"", "Welcome to your garden."},

    {"", "D A Y (1) : seed"},
    {"", "D A Y (2) : seedling"},
    {"", "D A Y (3) : bud"},
    {"", "D A Y (4) : stem & leaves"},
    {"", "D A Y (5) : plant"},

    {"", "Would you like to water your plant?"},
    {"", "Would you like to talk to your plant?"},
    {"", "Would you like to sing to your plant?"},
    {"", "Would you like to name your plant?"},
    {"", "Would you like to fertilize your plant?"}
}
// ============================== E X A M P L E  USER OBJECT
{ 1, "USERNAME", "PASSWORD", "USER'S PREFERRED NAME", "PLANT NAME", "PLANT DATE AND TIME OF BIRTH", "PLANT IS 0 DAYS OLD", "PLANT STATUS KEYWORDS"}

// ============================== PLANT S T A T U S  K E Y W O R D S
/*
"DRY" => plant needs to be watered to progress to next day
"MALNOURISHED" => plant needs to be fertilized to progress to next day
*/
// ============================== M E T H O D S
static void AuthenticateUser()
{
    // HANDLE USERNAME
    ASK USER FOR THEIR USERNAME
    GRAB THEIR RESPONSE
    LOOK FOR MATCHING USERNAME IN ITS DICTIONARY
    IF FOUND - 
    IF NOT FOUND -
        - - - LOOP - - -
        PROMPT USER FOR INCORRECT USERNAME
        PROMPT USER TO INPUT THEIR USERNAME AGAIN
        - - - LOOP END - - -
    IF FOUND - 
        // HANDLE PASSWORD
        ASK USER FOR THEIR PASSWORD
        GRAB RESPONSE
        LOOK AT USER OBJECT FOR MATCHING PASSWORD STRING
        IF PASSWORD MATCHES -
            WELCOME THE USER
        IF PASSWORD DOES NOT MATCH - 
            - - - LOOP - - -
            PROMPT USER ABOUT INCORRECT PASSWORD
            PROMPT USER TO RE-ENTER THEIR PASSWORD
            - - - LOOP END - - -
    // ASSIGN PROPER USER OBJECT TO PROGRAM 
    RETURN USER OBJECT WITH PLANT DATA
};

static void CurrentDateAndTime()
{
    // GRAB THE CURRENT DATE & TIME
    DateTime now = DateTime.Now;
    // PARSE FOR THE MONTH
    int month = now.Month;
    // PARSE FOR THE DAY
    int day = now.Day;
    // PARSE FOR THE YEAR
    int year = now.Year;
    // PARSE FOR THE TIME (MILITARY FORMAT)
    string time = now.ToString("HH:mm:ss")    
};

static void DetermineCurrentPlantStage()
{
    // CALCULATE THE PLANT'S CURRENT STAGE (DAY)
    // GRAB CURRENT DATETIME
    // GRAB PLANT DATETIME OF BIRTH
    // SUBTRACT CURRENT DATETIME FROM DATETIME OF BIRTH
    // DIVIDE SUBTRACTED TIME BY 24 HOURS
    // DISREGARD REMAINDER
    // EACH 24 HOURS ELAPSED = 1 DAY STAGE
    // RETURN DAY(S)
};

static void DashboardDisplay()
{
    // DISPLAY GROWTH STAGE : "Growth : Day (1)"
    // DISPLAY PLANT ART : <_-)) *^ +...)
        // COLOR ART GREEN
    // DISPLAY ACTION BUTTONS : [BUTTON NAME] [BUTTON NAME 2] [BUTTON NAME 3]
    // DISPLAY BRIEF INSTRUCTIONS : "Perform an action? Input and enter.
}

static void DisplayPlantArt(artworkKey)
{
    // PLANT ART STRING 
        // ART COLORED GREEN
}

static void DisplayPlantGrowthStage()
{
    //  INTERPOLATE INTO:
        // GROWTH : DAY (X)"
        // COLOR INTEGER GREEN
}

static void DisplayActionButtons()
{
    // GRAB AHOLD OF USER OBJECT PLANT DATA
    // DETERMINE WHAT ACTIONS TO DISPLAY
    // DISPLAY ACTION CHOICES ON THE SAME LINE
}


// ========================================================PROGRAM
class Program
{
    static async Task Main(string[] args)
    {
    /*
        DISPLAY TITLE OF PROGRAM
            Botanical Guardian
        DISPLAY ONE-LINER
            A Role-Playing & Garden Simulator
        LOG USER IN`
            Please, enter your username & press the [ENTER] key
            Please, enter your password & press the [ENTER] key
        DISPLAY GREETING
            Welcome home, USER_NICKNAME.
        DISPLAY PLANT ART
            |--(_.>
        DISPLAY PLANT AGE
            Your plant is (1) day old.
        DISPLAY PLANT STATUSES
            Your plant is (thirsty).
            Your plant is (malnourished).
            Your plant is (wilting).
        DISPLAY MENU OF ACTIONS
            [1] - [FEED] [2] - [WATER] [3] - [ADJUST LIGHTING]
        IF USER SELECTS FEED
            [1] - [Feed your plant with organic plant-based fertilizer] => (cannibalism path) (mouth, teeth)
            [2] - [Feed your plant with animal-based fertilizer] => (carnivore path) (claws, eyes)
            [3] - [Feed your plant with blood-based fertilizer] => (dark path) (devil tails, spikes)
    */
    }
}
