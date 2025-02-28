using System;
using SimTah.Documentation;
using SimTah.Mods;
namespace SimTah
{
  class Program
  {
    private static readonly string Ver = "1.0";
    static void Main()
    {
      while (true)
      {
        try
        {
          Console.Clear();
          Console.CursorVisible = true;
          Console.ForegroundColor = ConsoleColor.Blue;
          Console.WriteLine($"Добро пожаловать в SimTah. Версия: {Ver}\n");
          Console.ResetColor();

          Console.WriteLine("1) - Работа\n2) - Отдых\n3) - Документация\n4) - Выход из программы\n");

          Console.ForegroundColor = ConsoleColor.Yellow;
          Console.Write("Выберите режим: ");
          Console.ResetColor();
          string Input = Console.ReadLine()!;

          if (string.IsNullOrWhiteSpace(Input))
          {
            Console.Clear();
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вы пропустили аргумент!");
            Console.ResetColor();
            Thread.Sleep(2000);
            Console.Clear();
          }
          else
          {
            switch (Input)
            {
              case "1":
                Drive drive = new Drive()!;
                drive.ModDrive();
                break;
              case "2":
                Sleep sleep = new Sleep()!;
                sleep.ModSleep();
                break;
              case "3":
                Doc doc = new Doc()!;
                doc.Help();
                break;
              case "4":
                Console.Clear();
                Console.CursorVisible = false;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Выход из программы...");
                Console.ResetColor();
                Thread.Sleep(2000);
                Console.Clear();
                Console.CursorVisible = true;
                return;
              default:
                Console.Clear();
                Console.CursorVisible = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вы не выбрали режим!");
                Console.ResetColor();
                Thread.Sleep(2000);
                Console.Clear();
                break;
            }
          }
        }
        catch (Exception)
        {
          Console.Clear();
          Console.CursorVisible = false;
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Ошибка!");
          Console.ResetColor();
          Thread.Sleep(2000);
          Console.Clear();
        }
      }
    }
  }
}