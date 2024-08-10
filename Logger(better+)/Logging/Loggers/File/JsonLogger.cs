using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger_better__.Logging.Loggers.File
{
    public class JsonLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"JSON Log: {message}");
        }
    }
}
