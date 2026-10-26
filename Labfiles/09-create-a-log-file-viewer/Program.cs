// Log a new event

string logFile = "log.txt";
string timestamp = DateTime.Now.ToString("HH:mm:ss");

File.AppendAllText(logFile, $"[{timestamp}] Application started\n");

Console.WriteLine("Event logged.\n");

// Read back every logged event

Console.WriteLine("Event history:");

using StreamReader reader = new StreamReader(logFile);
string line;

while ((line = reader.ReadLine()) != null)
{
    Console.WriteLine(line);
}

// Count the logged events

string[] allLines = File.ReadAllLines(logFile);
Console.WriteLine($"\nTotal events logged: {allLines.Length}");
