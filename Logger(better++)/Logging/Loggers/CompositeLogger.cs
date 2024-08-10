using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger_better___.Logging.Loggers
{
    public class CompositeLogger : ILogger
    {
        private readonly List<ILogger> _loggers = new();

        public void AddLogger(ILogger logger)
        {
            _loggers.Add(logger);
        }

        public void Log(string message)
        {
            foreach (var logger in _loggers)
            {
                logger.Log(message);
            }
        }
    }

}
