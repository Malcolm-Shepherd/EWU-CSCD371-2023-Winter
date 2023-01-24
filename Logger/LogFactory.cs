namespace Logger
{
    public class LogFactory 
    {

        private string path = null;

        public FileLogger CreateLogger(string className)
        {
            BaseLogger logger = new FileLogger();
            BaseLogger.Name = className;
            BaseLogger.Path = path;

            if (BaseLogger.Path == null) return null;
            else return (FileLogger) logger;
        }

        public void ConfigureFileLogger(string inputPath)
        {
            path = inputPath;
        }
    }
}
