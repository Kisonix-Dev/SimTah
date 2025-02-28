using System;
namespace SimTah.Mods
{
  class Sleep
  {
    public void ModSleep()
    {
      Console.CursorVisible = false;
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("Отдых...");
      Console.ResetColor();

      Thread.Sleep(10 * 60 * 1000);

      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("Нажмите на клавишу: 'Enter' для выхода в главное меню.");
      Console.ResetColor();
      Console.ReadKey();
      Console.Clear();
    }
  }
}