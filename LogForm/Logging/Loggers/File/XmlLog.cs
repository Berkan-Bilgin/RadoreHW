using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogForm.Logging.Loggers.File
{
    [LogType("XmlLog")]
    public class XmlLog : ILogger
    {
        public string Log(string message)
        {
            string logMessage = $"Xml Log: {message}";
            return logMessage;
        }
    }
}
