namespace KittyAdventure;

public class Prompt
{
    public static void Show()
    {
        switch (States.GetCurrentState())
        {
            case StateType.Exploring:
                IO.Write("> ");
                break;
            case StateType.Conversation:
                IO.Write(":(y,n,leave %)");
                break;
            default:
                IO.Write("> ");
                break;
        }
    }
    
}