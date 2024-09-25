namespace KittyAdventure;

public static class Map
{
    public static void Initialize()
    {
        Location coliseum = new Location(name: "Coliseum",
            "Smells like singed fur the blood of the fallen. Doors lead north and south.");
        Location forestPath = new Location(name: "Forest Path",
            "A path with heavy paw traffic. Cats of all tribes wander down this main " + 
            "road. Path leads north and south.");
        
        coliseum.AddConnection(direction: "north", forestPath);
        forestPath.AddConnection(direction: "south", coliseum);
    }
}