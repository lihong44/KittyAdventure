using System.Data.SqlTypes;

namespace KittyAdventure;


public static class Game    
{

    private static bool isPlaying = true;
    public static void Play()
    {
        while (isPlaying)
        {
            CommandProcessor.GetCommand();
            
            /* Parser is the command prompter where you can type. It should be able to recognize "VERB NOUN" and translate raw text into "VERB NOUN".*/
            
            /*This breaks up words by the spaces*/
            
            
           /* string[] words = input.Split(' ');

            if (words.Length > 2)
                Console.WriteLine("Stop yapping bro!!");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }    
            
            // strings counted by the computer by starting at 0
            if (input == "exit")
            {
                isPlaying = false;
            }
            */
        }
        
    }
}

/* 9/10: comma seperated values is data seperated by commas -> breaks it up wherever there's a comma.
C# can do the same thing in text. we will split them by spaces.
Each method should do one thing at a time, try not to stuff the Player class*/

/* two types of class - one is purely organizational = static.
2nd class = organized and creates templates
for example for the second one: in bullet hell, you dont code every bullet. you
code one bullet and stamp out the rest */

/* As long as (WHILE) Game isnt done:
 it will loop through prompt => do stuff */