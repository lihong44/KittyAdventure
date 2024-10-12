namespace KittyAdventure;

public static class Player
{
    private static Location currentLocation;
    public static List<Item> Inventory;

    public static void Initialize()
    {
        currentLocation = Map.StartLocation;
        IO.Write(currentLocation.GetDescription());
        Inventory = new List<Item>();
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
            IO.Write("Can't go that way meow!");
        }
        
    }

    public static void Take(Command command)
    {
        IO.Write("taking " + command.Noun + "...");
   
        Item item = currentLocation.FindItem(command.Noun);

        if (item == null)
        {
            IO.Write("There is no " + command.Noun + " here. Had too much catnip?");
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
    public static string GetLocationDescription()
    {
        return currentLocation.GetDescription();
    }

    public static void Drop(Command command)
    {
        //find the item in inventory: lambda
        Item? item = Inventory.FirstOrDefault(i => 
            i.Name.ToLower() == command.Noun.ToLower());

        if (item != null)
        {
            Inventory.Remove(item);
            currentLocation.DropItem(item);
            IO.Write($"You drop the {item.Name}.");
        }
        //put item at location
        //print out text dropping item
        //else
        //print out you are dumb
    }

    public static void ShowInventory()
    {
        if (Inventory.Count == 0)
        {
            IO.Write("Not a single item to your name.");
        }
        else
        {
            IO.Write("You are carrying:");
            foreach (Item item in Inventory)
            {
                //office hours, ask about this
                string article = SemanticTools.CreateArticle(item.Name);
                IO.Write(" " + article + " " + item.Name);
                
            }
        }
    }
}