// CREATE SOMETHING GAME-LIKE AND FUN
// CONSIDER HOW TO MAKE SOMETHING SIMPLE ALONG THE LINES OF A PET SIMULATOR
// CONSIDER HOW TO USE ASYNC AWAIT
    // PET NEEDS TO EAT AND YOU HAVE TO COOK A FOOD ITEM
    // IF THE USER WAITS TOO LONG TO COOK THE FOOD ITEM - IT BURNS
    // IF THE USER WAITS NOT LONG ENOUGH- THE FOOD ITEM IS RAW AND UNEDIBLE
    // IF THE USER WAITS A SPECIFIED AMOUNT OF TIME - THE FOOD IS COOKED JUST RIGHT AND CAN BE FED 

// PET APPEARS TO BREATHE
// PET FRAME 1 (SMALLER)
// PET FRAME 2 (LARGER)
// TIMER IS UTILIZED & LOOP
// DISPLAY FRAME 1 UPON PAGE LOAD
// WAIT 1 SECOND
// CLEAR SCREEN
// DISPLAY FRAME 2
// WAIT 1 SECOND
// CLEAR SCREEN
// DISPLAY FRAME 1
// LOOP INFINITELY

// DISPLAY HUNGER GAUGE WITH 10 EMPTY 1-SECOND BLOCKS
// INITIALIZE TIMER
// EVERY 1 SECOND, ADD A FILLED-IN BLOCK
// AFTER 10 SECONDS, GAUGE IS FILLED
// WARN USER THAT PET IS HUNGRY AND NEEDS TO EAT 
// IF PET IS NOT FED WITHIN 10 SECONDS
    // PET TURNS INTO SKELETON
       // CLEAR SCREEN
       // DISPLAY SKELETON FRAME 
       // MAKE SKELETON BREATHE
    // ELSE LIVING PET CONTINUES TO BREATHE

//! + + + + + + + + + + + + + + + + + + + + + + + + + + + + + + +
// 'using' > KEYWORD > DIRECTIVE TO IMPORT NAMESPACES > GROUPS OF RELATED 'TYPES'
// 'System' > ROOT NAMESPACE > FUNDAMENTAL & BASE CLASSES
using System;
using System.Timers;

class Program
{
    // 'static' > KEYWORD FOR BELONGING TO THE 'Program' CLASS ITSELF AND NOT INSTANCE
    // 'void' > RETURN TYPE > SIGNIFY THAT METHOD DOES NOT RETURN A VALUE
    // 'main' > CONVENTIONAL METHOD NAME > 1ST TO GET CALLED > APPLICATION ENTRY POINT
    // '(string[] args)' > METHOD PARAMETERS PASSED IN WHEN APPLICATION STARTS 
    //      TAKE IN AN ARRAY OF STRINGS OF COMMAND-LINE ARGUMENTS
    static void Main(string[] args)
    {
        // INITIALIZE A TIMER TO BE TRIGGERED EVERY 1 SECOND
        // CLASS | STORED REFERENCE | INITIALIZATION OF INSTANCE | ARGUMENT FOR CONSTRUCTOR
        Timer timer = new Timer(1000);
    }
}
//! + + + + + + + + + + + + + + + + + + + + + + + + + + + + + + +

