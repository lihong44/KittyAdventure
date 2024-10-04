namespace KittyAdventure;

public static class Map
{
    public static Location StartLocation;
    public static void Initialize()
    {
        Location clawiseum = new Location(name: "Clawiseum",
            "Smells like singed fur and the blood of the fallen. Doors lead north and south.");
        Location whiskerWoods = new Location(name: "Whisker Woods",
            "A path with heavy paw traffic. Cats of all tribes wander down this main road. Path leads north and south.");
        Location tunaFalls = new Location(name: "Tuna Falls",
            "Tuna fish fly off the ledge, faintly splashing at the bottom of the lake. Path leads south.");
        Location pawprintPlaza = new Location(name: "Pawprint Plaza",
            "A bustling market filled with curious scents of fish and catnip. The crossroad leads in all directions.");
        Location catnipCove = new Location(name: "Catnip Cove",
            "REPLACE.");
        Location questionMark = new Location(name: "??????",
            "REPLACE.");
        Location meowManors = new Location(name: "Meow Manors",
            "Your neighborhood. The smell of homecooked tuna is in the air.");
        Location felineFairground = new Location(name: "Feline Fairground",
            "REPLACE.");
        Location yarnheartCastle = new Location(name: "Yarnheart Castle",
            "REPLACE.");
        Location grimRest = new Location(name: "The Grim Rest",
            "REPLACE.");
        Location hollowsTerror = new Location(name: "The Hollow's Terror",
            "REPLACE.");
        Location abandonedParts = new Location(name: "The Abandoned Parts",
            "REPLACE.");
        Location shattered = new Location(name: "The Shattered",
            "REPLACE.");
        Location loveless = new Location(name: "The Loveless",
            "REPLACE.");
        Location theVoid = new Location(name: "The Void",
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
        
        Item key = new Item(name: "Key", description: "Short for kitty. Helpful fella who opens your door for you", locationDescription: "There is a key near you.");
        meowManors.AddItem(key);

        Item beer = new Item(name: "Beer", description: "Who leaves a perfectly good beer outside?", locationDescription: "A beer sits beside the key.");
        meowManors.AddItem(beer);

    }
}