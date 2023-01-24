using System;

namespace Logger
{
    
    public abstract class BaseLogger
    {
        public  static string Name { get; set; } = string.Empty;
        public static string Path { get; set; } = string.Empty;
        public abstract void Log(LogLevel logLevel, string message);
    }
}
