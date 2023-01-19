namespace Logger
{
    public class LogFactory : BaseLogger
    {
        public static BaseLogger CreateLogger(string className)
        {
            Name = className;
            return null;
        }

        public override void Log(LogLevel logLevel, string message)
        {
            throw new System.NotImplementedException();
        }
    }
}
