using System;
namespace SimTah.Mods
{
  class Sleep
  {
    public void ModSleep()
    {
      while (true)
      {
        Console.WriteLine("Test");
        Console.ReadKey();
        return;
      }
    }
  }
}