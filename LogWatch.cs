using System;
using NLog;

namespace DemoLog
{
    internal class LogWatch
    {
        public static  readonly Logger logger = LogManager.GetCurrentClassLogger();

        public void logInfo(string message)
        {
            logger.Info(message);
        
        }
        public void logWarn(string message)
        {
           logger.Warn(message);
        }               
        public void logDebug(string message)
        {
           logger.Debug(message);
        }
        
    }
}
