namespace KittyAdventure;

public static class Parser
{
    public static Command Parse(string input)
    {
        Command command = new Command();    
        input = RemoveWhitespace(input);
        
        Console.WriteLine(input);

        input = input.ToLower();

        string[] words = input.Split(' ');

        if (words.Length == 2)
        {
            command.Verb = words[0];
            command.Noun = words[1];
        }

        if (words.Length == 1)
        {
            command.Verb = words[0];
        }

        return command;

    }
    

    public static string RemoveWhitespace(string input)
    {
        input = input.Trim();

        while (input.Contains("  "))
        {
            input = input.Replace("  ", " ");
        }

        return input;
    }
}

// agile development is building something as fast as possible => build a single method then check