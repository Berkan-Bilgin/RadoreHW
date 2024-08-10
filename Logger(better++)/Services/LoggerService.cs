using Logger_better___.Logging.Loggers.File;
using Logger_better___.Logging;
using Logger_better___.Logging.Loggers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger_better___.Logging.Loggers.Database;

namespace Logger_better___.Services
{
    public class LoggerService
    {
        public ILogger CreateBaseLogger()
        {
            var compositeLogger = new CompositeLogger();
            compositeLogger.AddLogger(new SQLServerLogger());
            return compositeLogger;
        }


        public ILogger CreateSalaryLogger()
        {
            var compositeLogger = new CompositeLogger();
            compositeLogger.AddLogger(new JsonLogger());
            compositeLogger.AddLogger(new XmlLogger());
            return compositeLogger;
        }

        public ILogger CreateLeaveLogger()
        {
            var compositeLogger = new CompositeLogger();
            compositeLogger.AddLogger(new MySQLLogger());
            compositeLogger.AddLogger(new SQLServerLogger());
            compositeLogger.AddLogger(new MongoDBLogger());


            return compositeLogger;
        }
    }

}
