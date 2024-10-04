namespace KittyAdventure;

public static class CommandValidator
{
    
    public static Command Validate(Command command)
    {
        // if the verb is in our list of verbs
        if (Vocabulary.IsVerb(command.Verb))
        {
            Debugger.Write("Standalone verb");
            if (Vocabulary.IsStandaloneVerb(command.Verb))
            {
                if (command.HasNoNoun())
                {
                    Debugger.Write("has no damn noun");
                    command.IsValid = true; 
                }
                else
                {
                    IO.Write("No clue what that even means meow!");
                }
            }
            else if (Vocabulary.IsNoun(command.Noun))
            {
                command.IsValid = true;
            }
            else
            {
                IO.Write("I don't know what" + command.Noun + "means...");
            }
            
        }
        else
        {
            IO.Write("Mrow, what does " + command.Verb + "mean?");
        }
        
        return command;
    }
}