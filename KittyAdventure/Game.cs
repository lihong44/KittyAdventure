using System.Data.SqlTypes;

namespace KittyAdventure;

/* two types of class - one is purely organizational = static. 
2nd class = organized and creates templates 
for example for the second one: in bullet hell, you dont code every bullet. you 
code one bullet and stamp out the rest */

/* As long as (WHILE) Game isnt done:
 it will loop through prompt => do stuff */
public static class Game    
{
    /*variable*/
    private static bool isPlaying = true;
    public static void Play()
    {
        while (isPlaying)
        {
            Console.WriteLine("> ");
            string input = Console.ReadLine();
            Console.WriteLine("Input was: " + input);

            if (input == "exit")
            {
                isPlaying = false;
            }
        }
        
    }
}