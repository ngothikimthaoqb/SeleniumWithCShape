using log4net;

using System.Reflection;


namespace SeleniumFramework.Helpers
{
    public static class LogHelper
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        public static void InitLog()
        {
            string batchID = DateTime.Now.ToString("yyyy-MM-dd hh-mm-ss tt");
            GlobalContext.Properties["LogName"] = batchID;
            GlobalContext.Properties["ProjectName"] = Assembly.GetCallingAssembly().GetName().Name;  

          
            log4net.Config.XmlConfigurator.Configure();
        }

        public static string CurrentLogFileName()
        {
            return Convert.ToString(log4net.GlobalContext.Properties["LogName"]);
        }

        public static void LogError(Exception ex)
        {
            _log.Error("System Error :" + ex.Message, ex);
        }

        public static void LogError(string message)
        {
            _log.Error("Custom Error :" + message);
        }

        public static void LogError(Exception ex, string message)
        {
            LogError(message);
            LogError(ex);
        }

        public static void LogWarning(string message)
        {
            _log.Warn(message);
        }

        public static void LogMessage(string message)
        {
            _log.Info(message);
        }

        public static void LogDebug(string message)
        {
            _log.Debug(message);
        }
    }

}