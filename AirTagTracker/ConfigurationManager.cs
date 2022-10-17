
using Microsoft.Extensions.Configuration;

namespace AirTagTracker
{

    static class ConfigurationManager
    {
        private static IConfigurationRoot _config;

        public static OS_Selection _os_Selection { get; }

        public static string ConnectionString { get { return _config["SQLServerConnectionString"]; } }

        public static int SampleTime { get { return Convert.ToInt32(_config["SampleTimeMinutes"]) * 60000; } }

        public static string CacheFilepath
        {
            get
            {
                switch (_os_Selection)
                {
                    case OS_Selection.Windows:
                        return _config["WindowsFilepath"];
                    case OS_Selection.MacOS:
                        return _config["MacOSFilepath"];
                    default:
                        return "";
                }
            }
        }

        static ConfigurationManager()
        {
            // Configuration Management Refactor into its own class(es)
            var builder = new ConfigurationBuilder()
                             .AddJsonFile($"appsettings.json", true, true);

            _config = builder.Build();

            // Can the program infer the OS? 
            _os_Selection = OS_Selection.MacOS;
        }
    }

    enum OS_Selection
    {
        Windows,
        MacOS
    }
}