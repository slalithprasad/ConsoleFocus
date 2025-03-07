# Console Focus ⏳  

A **Simple C# Console App** that helps you stay productive by setting a focus timer with reminders. It tracks your break time and allows you to restart focus sessions, making it an ideal tool for deep work and time management.  

## How It Works  

- Enter your **focus session duration** (in minutes).  
- Enter a **custom reminder message** (or use the default message).  
- **Work until the reminder appears**.  
- After the session ends, take a **break** and press **Enter** when you are back.  
- The app calculates your **break duration** and asks for a new focus session.  

## Prerequisites  
- Download and Install [.NET 9.0 SDK](https://dotnet.microsoft.com/en-us/download)  

## Setup  
1. Clone the repository:  
    ```bash
    git clone https://github.com/slalithprasad/ConsoleFocus
    cd ConsoleFocus
    ```
2. Install the required NuGet packages:  
    ```bash
    dotnet restore
    ```

## Running the App  
```bash
dotnet run
```

## Usage  
- 🕒 Enter your **focus session duration** (in minutes).  
- 💬 Enter a **custom reminder message** (optional).  
- 🎯 Work until the reminder appears.  
- 🔔 When the reminder appears, a **sound notification** plays (Windows only).  
- ⏸️ Take a break and press **Enter** when you're back.  
- 🕒 The app calculates your **break time** and lets you restart focus sessions.  

## Example Session  

```text
🟢 Console Focus Started! Press Ctrl+C to exit.

Enter focus session duration in minutes: 30
Do you want to play music after the session? (y/n): y
Enter your custom reminder message (or press Enter for default): Take a Break!

🎯 Focus session started at 14:00. You will be reminded in 30 minutes...

🔔 Reminder: Take a Break! (14:30)
⏸️ Press Enter when you are back from your break...

🕒 Break duration: 5 minutes.

Enter focus session duration in minutes: 25
Do you want to play music after the session? (y/n): y
Enter your custom reminder message (or press Enter for default): Take a Break!

🎯 Focus session started at 14:35. You will be reminded in 25 minutes...
``` 
---

**Stay productive!** 🚀⏳ 