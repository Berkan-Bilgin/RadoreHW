using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger_better___.Logging.Loggers.Database
{
    internal class MongoDBLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"MongoDB Log: {message}");
        }
    }
}
