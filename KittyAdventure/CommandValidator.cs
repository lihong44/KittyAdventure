namespace KittyAdventure;

public static class CommandValidator
{
    
    public static Command Validate(Command command)
    {
        // if the verb is in our list of verbs
        if (Vocabulary.IsVerb(command.Verb))
        {
            //if the verb is ok by itself
            if (Vocabulary.IsStandaloneVerb(command.Verb))
            {
                command.IsValid = true;
            }
            else if (Vocabulary.IsNoun(command.Noun))
            {
                command.IsValid = true;
            }
            
        }
        
        return command;
    }
}