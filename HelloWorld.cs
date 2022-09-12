using LoggerLibrary.Logging.Log4Net.Loggers;
using LoggerLibrary.LoggingAttribute;

namespace LoggerLibrary
{
    
    [LogAspect(typeof(FileLogger))]
    public class HelloWorld
    {
      
    }
}
