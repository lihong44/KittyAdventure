namespace KittyAdventure;

// one line comment

public static class CommandProcessor
{
    public static void GetCommand()
    {
        // get the raw input string
        
        Console.Write("> ");
        string input = Console.ReadLine();
        
        Command command = Parser.Parse(input);

        //validate command ; 
        //do we know the words
        //


    }
}