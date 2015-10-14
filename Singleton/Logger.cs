using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Logger
    {
        private static Logger logger = null;

        private Logger() { }

        public static Logger GetInstance()
        {
            if (logger == null)
                logger = new Logger();

            return logger;
        }

        public void WriteToFile()
        {
            Console.WriteLine("Write to file");
        }
    }
}
