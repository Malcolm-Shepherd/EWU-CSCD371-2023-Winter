using System.Runtime.InteropServices.ComTypes;

namespace Logger
{
    public class LogFactory 
    {

        private string path = string.Empty;

        public BaseLogger? CreateLogger(string nameToPass)
        {
            BaseLogger.Name = nameToPass;
            BaseLogger logger = new FileLogger();                
            BaseLogger.Path = path;

            if (BaseLogger.Path == string.Empty) return null;
            else return logger;
        }

        public void ConfigureFileLogger(string inputPath)
        {
            path = inputPath;
        }
    }
}
