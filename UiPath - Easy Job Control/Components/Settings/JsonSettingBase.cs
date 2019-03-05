using System.IO;
using Newtonsoft.Json;

namespace UiPathEJC.Components.Settings
{
    public class JsonSettingBase<T> where T : new()
    {
        public const string DefaultFilename = "settings.json";

        public void Save(string fileName = DefaultFilename)
        {
            File.WriteAllText(fileName, JsonConvert.SerializeObject(this));
        }

        public static void Save(T pSettings, string fileName = DefaultFilename)
        {
            File.WriteAllText(fileName, JsonConvert.SerializeObject(pSettings));
        }

        public static T Load(string fileName = DefaultFilename)
        {
            var t = new T();
            if (File.Exists(fileName))
                t = JsonConvert.DeserializeObject<T>(File.ReadAllText(fileName));
            return t;
        }
    }
    class JsonSettingBase
    {
    }
}