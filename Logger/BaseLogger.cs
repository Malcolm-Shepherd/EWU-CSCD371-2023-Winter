namespace Logger
{
    
    public abstract class BaseLogger
    {
        public static string Name { get; set; }
        public static string Path { get; set; }
        public abstract void Log(LogLevel logLevel, string message);
    }
}
