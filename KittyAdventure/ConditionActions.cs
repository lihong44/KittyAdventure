namespace KittyAdventure;

public static class ConditionActions
{
    public static Action WriteOutput(string message)
    {
        return () => IO.WriteLine(message);
    }
    
    //add a map connection 
    //remove a map connection
    //if player dies
    //add item to inventory
    //add item to room
    //remove item from inventory
    //remove item from room
    //spawn mob
    //remove mob
    //change state
}