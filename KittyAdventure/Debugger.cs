using System.Runtime.InteropServices;

namespace KittyAdventure;

public static class Debugger
{
    private static bool isActive = false;
    
    public static void Write(string message)
    {
        if (isActive)
        {
            IO.Write(message);
        }
    }

    public static void Tron()
    {
        isActive = true;
        IO.Write("Debugging enabled dipshit");
    }
    public static void Troff()
    {
        isActive = false;
        IO.Write("Debugging disabled dumbass");
    }
}