using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LogForm.Logging
{
    public class LoggerFactory
    {
        //Verilen namespace içindek sana parametre olarak gelen className ile ilgili bir class var ise
        //ondan runtime dinamik olarak bir nesne oluştur
        //oluşturdunğun nesneyi de ILogger cast ederek oluştur. 
        //dosyaları istediğim yere olusturamıyorum ama daha az yeri taradığı için performansı daha iyidir.


        //public ILogger CreateLogger(string namespaceName, string className)
        //{
        //    var fullClassName = $"LogForm.Logging.Loggers.{namespaceName}.{className}";
        //    var newInstance = Assembly.GetAssembly(typeof(ILogger)).CreateInstance(fullClassName);
        //    return (ILogger)newInstance;
        //}
        public ILogger CreateLogger(string logTypeName)
        {
            // Assembly'deki tüm ILogger implementasyonlarını bul
            //interface  ve abstract class olmayan
            //daha esnek ama tüm assemblyde ILogger classları aramak mantıklı mı bilemedim.
            var loggerTypes = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => typeof(ILogger).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
                .ToList();

            // İstenen logTypeName'e uygun olanını bul
            //var loggerType = loggerTypes.FirstOrDefault(t =>
            //    t.GetCustomAttribute<LogTypeAttribute>()?.LogTypeName == logTypeName);


            var loggerType = loggerTypes.FirstOrDefault(t => t.Name == logTypeName);

            if (loggerType != null)
            {
                return (ILogger)Activator.CreateInstance(loggerType);
            }

            throw new ArgumentException($"Logger type '{logTypeName}' not found.");
        }
    }
}
