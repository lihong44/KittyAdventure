namespace KittyAdventure;

public static class Player
{
    private static Location currentLocation;
    public static List<Item> Inventory;

    public static void Initialize()
    {
        currentLocation = Map.StartLocation;
        IO.Write(currentLocation.GetDescription());
    }
    public static void Move(Command command)
    {
        if (currentLocation.CanMoveInDirection(command.Noun))
        {
              currentLocation = currentLocation.GetLocationInDirection(command.Noun);
              IO.Write(currentLocation.GetDescription());
        }
          
        else
        {
            IO.Write("cant go that way meow");
        }
        
    }

    public static void Take(Command command)
    {
        IO.Write("taking " + command.Noun);
   
        Item item = currentLocation.FindItem(command.Noun);

        if (item == null)
        {
            IO.Write("There is no " + command.Noun + "here. Had too much catnip?");
        }
        else if (!item.IsTakeable)
        {
            IO.Write("The " + command.Noun + " cannot fit in your pocket. A shame...");
        }
        else
        {
            Inventory.Add(item);
            currentLocation.RemoveItem(item);
            IO.Write("You take the " + command.Noun + ".");
            
        }

       
    }
}