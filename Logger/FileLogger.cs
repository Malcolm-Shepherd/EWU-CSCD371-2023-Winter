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
            using (StreamWriter sw = File.AppendText(path))
            {
                message += " - " + DateTime.Now.ToString() + " " + Name + " " + logLevel.ToString();
                sw.WriteLine(message);
            }
            // File.WriteAllText(path, message);   
            /*using (StreamWriter fileAppender = File.AppendText(path))
            {
                fileAppender.WriteLine(message);
            }*/
            //throw new NotImplementedException();
        }
    }
}
