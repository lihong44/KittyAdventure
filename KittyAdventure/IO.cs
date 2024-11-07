namespace KittyAdventure;

public static class IO
{
   public static void Write(string output)
   {
      Console.WriteLine(output);
   }
   
   public static string Read()
   {
      return Console.ReadLine();
   }

   public static void Error(string output)
   {
      Console.ForegroundColor = ConsoleColor.Red;
      Write("ERROR: " + output);
      Console.ResetColor();
   }
}