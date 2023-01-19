using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Logger
{
    public class FileLogger : BaseLogger
    {
        public override void Log(LogLevel logLevel, string message)
        {
            string path = "Log.txt";
            if (!File.Exists(path)) 
            {
                File.WriteAllText(path, message);   
            }
            File.AppendAllText(path, "\n" + message);
            /*using (StreamWriter fileAppender = File.AppendText(path))
            {
                fileAppender.WriteLine(message);
            }*/
            //throw new NotImplementedException();
        }
    }
}
