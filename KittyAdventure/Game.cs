using System.Data.SqlTypes;

namespace KittyAdventure;
public static class Game    
{

    private static bool isPlaying = true;
    public static void Play()
    {
        Location location1 = new Location(name: "Forest Clearing",
            description: "forest filled with kitties yay");
        Location locationHallway = new Location(name: "Hallway",
            description: "yerrr hallway");
        while (isPlaying)
        {
            Command command = CommandProcessor.GetCommand();
            if (command.IsValid)
            {
                IO.Write(command.ToString());
                if (command.Verb == "tron")
                {
                    Debugger.Tron();
                }
                else if (command.Verb == "troff")
                {
                    Debugger.Troff();
                }
            }
            else
            {
                IO.Write("Invalid Command");
            }
            
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