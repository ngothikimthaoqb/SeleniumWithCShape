using Newtonsoft.Json.Linq;
using SeleniumFramework.Models;


namespace SeleniumFramework.Providers
{
    public class ConfigurationProvider
    {
        private const string WebDriverConfigSectionName = "webdriver";
        private const string EnvironmentConfigSectionName = "environment";
        private const string FilePath = @"../../../Configurations/ConfigSetting.json";
        private static readonly string SettingsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, FilePath);

        public static WebDriverConfiguration WebDriver =>
            Load<WebDriverConfiguration>(WebDriverConfigSectionName);

        public static EnvironmentConfiguration Environment =>
            Load<EnvironmentConfiguration>(EnvironmentConfigSectionName);

        private static T Load<T>(string sectionName) =>
            JObject.Parse(File.ReadAllText(SettingsPath)).SelectToken(sectionName).ToObject<T>();
    }
}
