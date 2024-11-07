namespace KittyAdventure;

public class ConversationCommandValidator
{
    private Dictionary<string, Action<Command>> commandMap =
        new Dictionary<string, Action<Command>>()
        {
            {"y", Yes}
            ,{"n", No}
            ,{"leave", Leave}
        };
    
    public void Handle(Command command)
    { 
        if (commandMap.ContainsKey(command.Verb))
        {
            Action<Command> action = commandMap[command.Verb];
            action.Invoke(command);
        }
        else
        {
            IO.Write("I dont know how to do that.");
        }
    }


    private static void Yes(Command obj)
    {
        
    }
    private static void No(Command obj)
    {
        
    }
    private static void Leave(Command obj)
    {
        
    }


   
}