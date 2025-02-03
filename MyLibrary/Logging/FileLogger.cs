namespace MyLibrary;

public class FileLogger(string filename) : ILogger
{
    public void Log(LogLevel level, string message)
    {
        string content = $"{DateTime.Now:dd.mm.yyyy}\t{level}\t{message} {Environment.NewLine}";
        File.AppendAllText(filename, content);
    }
}