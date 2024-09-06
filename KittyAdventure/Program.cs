/*allows u to have classes that have 
the same name that do differ stuff*/
namespace KittyAdventure;

/* a class is a container that collects code. Otherwise it will lead 
to messiness and thousands of lines*/

/*defining a class below. all classes MUST have the same as the file*/

public class Program 
{
    /* method - code that does smth for you. 
    you must have a first method that looks like below*/
    public static void Main(string[] args)
    {
        Game.Play();   
    }
}

/* ^very normal to have program class not do alot. 
just here to tell the game to go */