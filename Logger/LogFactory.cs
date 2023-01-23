namespace Logger
{
    public class LogFactory : BaseLogger
    {

        private string path;

        public BaseLogger CreateLogger(string className, string inputPath)
        {
            Name = className;
            ConfigureFileLogger(inputPath);
            return null;
        }

        public override void Log(LogLevel logLevel, string message)
        {
            throw new System.NotImplementedException();
        }

        private void ConfigureFileLogger(string inputPath)
        {
            path = inputPath;
        }
    }
}
