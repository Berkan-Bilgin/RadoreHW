using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger_better_
{
    public class XmlLog : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Xml'e kaydedildildi: " + message);
        }
    }
}

