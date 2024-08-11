using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogForm.Logging.Loggers.Database
{

    [LogType("DbLog")]
    public class DbLog : ILogger
    {
        public string Log(string message)
        {
            string logMessage = $"DB Log: {message}";
            return logMessage;
        }
    }
}
