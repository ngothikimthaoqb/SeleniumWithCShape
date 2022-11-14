using Newtonsoft.Json;

namespace SeleniumFramework.Helpers.Providers
{
    public static class DataProvider
    {
        public static T LoadJsonFile<T>(string filename)
        {
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(Path.Combine(AppDomain
                .CurrentDomain
                .BaseDirectory,
                $@"..\..\..\Data\{filename}.json")));
        }

        public static T LoadXMLFile<T>(string filename)
        {
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(Path.Combine(AppDomain
                .CurrentDomain
                .BaseDirectory,
                $@"..\..\..\Data\{filename}.json")));
        }
    }
}
