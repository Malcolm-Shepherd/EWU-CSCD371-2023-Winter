using System;
using System.Data.Common;

namespace Logger
{
    public static class BaseLoggerMixins
    {
        public static void Error(this BaseLogger logger, string input, int parameter)
        {
            if (logger is null || input is null || parameter is 0)
                throw new ArgumentNullException();
            input = String.Format(input, parameter);   
            logger.Log(LogLevel.Error, input);
        }
        public static void Warning(this BaseLogger logger, string input, int parameter)
        {
            if (logger is null || input is null || parameter is 0)
                throw new ArgumentNullException();
            input = String.Format(input, parameter);
            logger.Log(LogLevel.Error, input);
        }
        public static void Information(this BaseLogger logger, string input, int parameter)
        {
            if (logger is null || input is null || parameter is 0)
                throw new ArgumentNullException();
            input = String.Format(input, parameter);
            logger.Log(LogLevel.Error, input);
        }
        public static void Debug(this BaseLogger logger, string input, int parameter)
        {
            if (logger is null || input is null || parameter is 0)
                throw new ArgumentNullException();
            input = String.Format(input, parameter);
            logger.Log(LogLevel.Error, input);
        }
    }
}
