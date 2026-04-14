using System.IO;
using System.Media;
using System;

public static class AudioManager
{
    public static void PlayGreeting()
    {
        try
        {
            string fileName = "Hello.wav";
            // Use application base directory so the relative path is resolved to the exe folder.
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            if (!File.Exists(path))
            {
                Console.WriteLine($"⚠️ Audio file not found at: {path}");
                return;
            }

            var player = new SoundPlayer(path);
            // Load synchronously to surface any loading errors before playing.
            player.Load();
            player.PlaySync();
        }
        catch (Exception ex)
        {
            // Surface the actual exception so you can diagnose the failure.
            Console.WriteLine("⚠️ Audio failed to play: " + ex.Message);
        }
    }
}