namespace KittyAdventure;

public class CommandHandler
{
    public static void Handle(Command command)
    {
        switch (States.GetCurrentState())
        {
            case StateType.Exploring:
                ExplorationCommandHandler.Handle(command);
                break;
            case StateType.Conversation:
                ExplorationCommandHandler.Handle(command);
                break;
            
        }
    }
}