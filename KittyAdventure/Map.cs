namespace KittyAdventure;

public static class Map
{
    public static Location StartLocation;

    private static Dictionary<string, Location> nameToLocation =
        new Dictionary<string, Location>();
    public static void Initialize()
    {
        Location clawiseum = AddLocation(name: "Clawiseum",
            "Smells like singed fur and the blood of the fallen. Doors lead north and south.");
        Location whiskerWoods = AddLocation(name: "Whisker Woods",
            "A path with heavy paw traffic. Cats of all tribes wander down this main road. Path leads north and south.");
        Location tunaFalls = AddLocation(name: "Tuna Falls",
            "Tuna fish fly off the ledge, faintly splashing at the bottom of the lake. Path leads south.");
        Location pawprintPlaza = AddLocation(name: "Pawprint Plaza",
            "A bustling market filled with curious scents of fish and catnip. The crossroad leads in all directions.");
        Location catnipCove = AddLocation(name: "Catnip Cove",
            "REPLACE.");
        Location questionMark = AddLocation(name: "??????",
            "REPLACE.");
        
       // Location meowManors = new Location(name: "Meow Manors",
           // "Your neighborhood. The smell of homecooked tuna is in the air.");

        Location meowManors = AddLocation("Meow Manors",
            "Your neighborhood. The smell of homecooked tuna is in the air.");
        
        
        Location felineFairground = AddLocation(name: "Feline Fairground",
            "REPLACE.");
        Location yarnheartCastle = AddLocation(name: "Yarnheart Castle",
            "REPLACE.");
        Location grimRest = AddLocation(name: "The Grim Rest",
            "REPLACE.");
        Location hollowsTerror = AddLocation(name: "The Hollow's Terror",
            "REPLACE.");
        Location abandonedParts = AddLocation(name: "The Abandoned Parts",
            "REPLACE.");
        Location shattered = AddLocation(name: "The Shattered",
            "REPLACE.");
        Location loveless = AddLocation(name: "The Loveless",
            "REPLACE.");
        Location theVoid = AddLocation(name: "The Void",
            "REPLACE.");
        
        
        
        
        clawiseum.AddConnection(direction: "north", whiskerWoods);
        clawiseum.AddConnection(direction: "south", questionMark);
        
        whiskerWoods.AddConnection(direction: "north", tunaFalls);
        whiskerWoods.AddConnection(direction: "east", pawprintPlaza);
        whiskerWoods.AddConnection(direction: "south", clawiseum);
        whiskerWoods.AddConnection(direction: "west", catnipCove);
        
        tunaFalls.AddConnection(direction: "south", whiskerWoods);
        
        pawprintPlaza.AddConnection(direction: "north", meowManors);
        pawprintPlaza.AddConnection(direction: "east", felineFairground);
        pawprintPlaza.AddConnection(direction: "south", yarnheartCastle);
        pawprintPlaza.AddConnection(direction: "west", whiskerWoods);
        
        catnipCove.AddConnection(direction: "east", whiskerWoods);
        
        questionMark.AddConnection(direction: "north", clawiseum);
        questionMark.AddConnection(direction: "descend", grimRest);
        
        meowManors.AddConnection(direction: "south", pawprintPlaza);
        
        felineFairground.AddConnection(direction: "west", pawprintPlaza);
        
        yarnheartCastle.AddConnection(direction: "north", pawprintPlaza);
        
        grimRest.AddConnection(direction: "ascend", questionMark);
        grimRest.AddConnection(direction: "east", abandonedParts);
        grimRest.AddConnection(direction: "descend", shattered);
        grimRest.AddConnection(direction: "west", hollowsTerror);
        
        hollowsTerror.AddConnection(direction: "east", grimRest);
        
        abandonedParts.AddConnection(direction: "west", grimRest);
        
        shattered.AddConnection(direction: "ascend", grimRest);
        shattered.AddConnection(direction: "descend", loveless);
        
        loveless.AddConnection(direction: "ascend", shattered);
        loveless.AddConnection(direction: "descend", theVoid);
        
        theVoid.AddConnection(direction: "ascend", loveless);

        StartLocation = meowManors;
        
        Item key = new Item(name: "Key", description: "Short for kitty. Helpful fella who opens your door for you", initialLocationDescription: "There is a key waving at you.");
        meowManors.AddItem(key);

        Item beer = new Item(name: "Beer", description: "Who leaves a perfectly good beer outside?", initialLocationDescription: "A beer sits off to the side, trying to play it cool.");
        meowManors.AddItem(beer);

    }

    private static Location AddLocation(string name, string description)
    {
        Location location = new Location(name, description);
        nameToLocation.Add(name, location);

        return location;

   
    }

    public static void AddConnection(string startLocation,
        string direction, string endLocation)
    {
        Location? start = FindLocation(startLocation);
        Location? end = FindLocation(endLocation);
        if (start == null || end == null)
        {
            IO.Error("Could not find location: " + startLocation + "and/or " + endLocation);
            return;
        }
        start.AddConnection(direction, end);
    }
    public static void RemoveConnection(string locationName, string direction)
    {
        Location? location = FindLocation(locationName);
        if (location == null)
            return;
        location.RemoveConnection(direction);
    }

    public static Location? FindLocation(string location)
    {
        if (nameToLocation.ContainsKey(location))
            return nameToLocation[location];
        return null;
    }


    public static bool DoesLocationExist(string locationName)
    {
        if (FindLocation(locationName) != null)
            return true;
        return false;
    }

    public static Location? GetLocationByName(string locationName)
    {
        Location? location = FindLocation(locationName);
        return location;
    }
}
