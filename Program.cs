using System.Diagnostics;

Console.WriteLine("🟢 Console Focus Started! Press Ctrl+C to exit.");

while (true)
{
    Console.Write("\nEnter focus session duration in minutes: ");
    string? input = Console.ReadLine();
    int focusMinutes = 0;

    while (!int.TryParse(input, out focusMinutes) || focusMinutes <= 0)
    {
        Console.Write("Invalid input. Enter a valid number of minutes: ");
        input = Console.ReadLine();
    }

    Console.Write("Do you want to play music after the session? (y/n): ");
    string? playMusicInput = Console.ReadLine();

    while (string.IsNullOrEmpty(playMusicInput) || !playMusicInput.Equals("y", StringComparison.OrdinalIgnoreCase) && !playMusicInput.Equals("n", StringComparison.OrdinalIgnoreCase))
    {
        Console.Write("Invalid input. Enter 'y' for yes or 'n' for no: ");
        playMusicInput = Console.ReadLine();
    }

    Console.Write("Enter your custom reminder message (or press Enter for default): ");
    string? customMessage = Console.ReadLine();
    string reminderMessage = string.IsNullOrEmpty(customMessage) ? "⏳ Time to take a short break and refocus!" : customMessage;

    bool playMusic = playMusicInput == "y";

    Console.WriteLine($"\n🎯 Focus session started at {DateTime.Now:HH:mm}, You will be reminded in {focusMinutes} minutes...");
    Thread.Sleep(focusMinutes * 60 * 1000);

    if (playMusic)
    {
        PlayMusic();
    }

    Console.WriteLine($"\n🔔 Reminder: {reminderMessage} ({DateTime.Now:HH:mm})");

    Console.WriteLine("\n⏸️ Press Enter when you are back from your break...");
    Stopwatch breakTimer = Stopwatch.StartNew();
    Console.ReadLine();
    breakTimer.Stop();

    int breakMinutes = (int)breakTimer.Elapsed.TotalMinutes;
    Console.WriteLine($"🕒 Break duration: {breakMinutes} minutes.");
}


void PlayMusic()
{
    if (OperatingSystem.IsWindows())
    {
        int baseDuration = 125;

        (int frequency, int duration)[] melody = {
        (660, baseDuration), (660, baseDuration), (0, baseDuration), (660, baseDuration),
        (0, baseDuration), (510, baseDuration), (660, baseDuration), (770, baseDuration * 2),
        (0, baseDuration), (380, baseDuration * 2), (0, baseDuration),

        (510, baseDuration), (0, baseDuration), (380, baseDuration * 2), (0, baseDuration),
        (320, baseDuration * 2), (0, baseDuration), (440, baseDuration), (480, baseDuration),
        (450, baseDuration), (430, baseDuration), (380, baseDuration), (660, baseDuration),
        (760, baseDuration), (860, baseDuration), (700, baseDuration), (760, baseDuration),
        (660, baseDuration), (520, baseDuration), (580, baseDuration), (480, baseDuration)
    };

        foreach (var (freq, duration) in melody)
        {
            if (freq > 0)
                Console.Beep(freq, duration);
            Thread.Sleep(50);
        }
    }
}