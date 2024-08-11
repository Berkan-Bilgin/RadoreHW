using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogForm.Logging.Loggers.File
{
    [LogType("JsonLog")]
    public class JsonLog : ILogger
    {
        public string Log(string message)
        {
            string logMessage = $"JSON Log: {message}";
            return logMessage;
        }
    }
}
