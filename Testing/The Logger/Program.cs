using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace The_Logger
{
    class Program
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            log.Info("Test");

            log.Error("Issues on logger", new Exception("Test errors"));

            log.ErrorFormat("yyyy/MM/DD", DateTime.Now);

            Console.ReadLine();
        }
    }
}
