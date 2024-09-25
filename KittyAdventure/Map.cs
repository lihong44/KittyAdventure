namespace KittyAdventure;

public static class Map
{
    public static void Initialize()
    {
        Location clawiseum = new Location(name: "Clawiseum",
            "Smells like singed fur and the blood of the fallen. Doors lead north and south.");
        Location whiskerWoods = new Location(name: "Whisker Woods",
            "A path with heavy paw traffic. Cats of all tribes wander down this main road. Path leads north and south.");
        Location turnaFalls = new Location(name: "Tuna Falls",
            "REPLACE.");
        Location pawprintPlaza = new Location(name: "Pawprint Plaza",
            "REPLACE.");
        Location catnipCove = new Location(name: "Catnip Cove",
            "REPLACE.");
        
        
        clawiseum.AddConnection(direction: "north", whiskerWoods);
        clawiseum.AddConnection(direction: "south", questionMark);
        whiskerWoods.AddConnection(direction: "north", tunaFalls);
        whiskerWoods.AddConnection(direction: "east", pawprintPlaza);
        whiskerWoods.AddConnection(direction: "south", clawiseum);
        whiskerWoods.AddConnection(direction: "west", catnipCove);
    }
}