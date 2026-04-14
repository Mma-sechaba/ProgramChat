using System;
using System.Threading;

public static class UIHelper
{
    public static void ShowAsciiArt()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.WriteLine(@"
  ╔══════════════════════════════════════╗
  ║      🔐 CYBER SECURITY BOT 🔐       ║
  ║   Protect • Detect • Stay Secure    ║
  ╚══════════════════════════════════════╝
        ");

        Console.ResetColor();
    }

    public static string GetUserName()
    {
        WritePrompt("Enter your name: ");
        string name = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(name))
        {
            WriteError("Name cannot be empty.");
            WritePrompt("Enter your name: ");
            name = Console.ReadLine();
        }

        return name;
    }

    public static void TypeText(string text)
    {
        Console.ForegroundColor = ConsoleColor.Green;

        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(20);
        }

        Console.WriteLine();
        Console.ResetColor();
    }

    public static void WritePrompt(string message)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(message);
        Console.ResetColor();
    }

    public static void WriteError(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("⚠️ " + message);
        Console.ResetColor();
    }

    public static void WriteSuccess(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("✅ " + message);
        Console.ResetColor();
    }
}