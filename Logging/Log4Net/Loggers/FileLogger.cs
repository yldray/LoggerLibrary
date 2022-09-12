using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerLibrary.Logging.Log4Net.Loggers
{
    public class FileLogger : LoggerServiceBase
    {
        public FileLogger() : base("JsonFileLogger")
        {
        }
    }
}
