using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogForm.Logging
{
    public class LoggerService
    {
        private readonly ILogger _logger;

        public LoggerService(ILogger logger)
        {
            _logger = logger;
        }

        public string Log(string message)
        {
            string logMessage = _logger.Log(message);
            return logMessage;
        }


    }
}
