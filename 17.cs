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
    // HANDLE PASSWORD
    // ASSIGN PROPER USER OBJECT TO PROGRAM
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
};