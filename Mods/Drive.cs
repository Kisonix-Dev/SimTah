using System;
namespace SimTah.Mods
{
  class Drive
  {
    public void ModDrive()
    {
      Console.CursorVisible = false;
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("Работа...");
      Console.ResetColor();

      Thread.Sleep(30 * 60 * 1000);

      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("Нажмите на клавишу: 'Enter' для перехода в режим отдыха.");
      Console.ResetColor();
      Console.ReadKey();
      Console.Clear();

      Sleep sleep = new Sleep()!;
      sleep.ModSleep();
    }
  }
}