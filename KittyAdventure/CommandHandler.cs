namespace KittyAdventure;

public static class CommandHandler
{
    private static Dictionary<string, Action<Command>> commandMap =
        new Dictionary<string, Action<Command>>()
        {
            {"go", Move}
            ,{"take", Take}
            ,{"tron", Tron}
            ,{"troff", Troff}
        };
    public static void Handle(Command command)
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

    private static void Move(Command command)
    {
        Player.Move(command);
    }

    private static void Take(Command command)
    {
        Player.Take(command);
    }
    private static void Tron(Command command)
    {
        Debugger.Tron();
    }
    private static void Troff(Command command)
    {
        Debugger.Troff();
    }

}