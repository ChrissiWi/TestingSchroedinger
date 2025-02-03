namespace MyLibrary;

public enum LogLevel{
    Info, Warning, Error, Fatal
}

public interface ILogger{
    public void Log(LogLevel level, string message);
}