using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogForm.Logging.Loggers.Database
{
    [LogType("MySQLLog")]
    public class MySQLLog : ILogger
    {
        public string Log(string message)
        {
            string logMessage = $"MySQL Log: {message}";
            return logMessage;
        }
    }
}
