namespace Logger
{
    public class LogFactory 
    {

        private string path = string.Empty;

        public FileLogger? CreateLogger(string className)
        {
            BaseLogger logger = new FileLogger();
            BaseLogger.Name = className;
            BaseLogger.Path = path;

            if (BaseLogger.Path == string.Empty) return null;
            else return (FileLogger) logger;
        }

        public void ConfigureFileLogger(string inputPath)
        {
            path = inputPath;
        }
    }
}
