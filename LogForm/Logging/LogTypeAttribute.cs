using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogForm.Logging
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class LogTypeAttribute : Attribute
    {
        public string LogTypeName { get; }


        public LogTypeAttribute(string logTypeName)
        {
            LogTypeName = logTypeName;

        }
    }
}
