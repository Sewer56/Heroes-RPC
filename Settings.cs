using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Reloaded_Mod_Template
{
    public class Settings
    {
        // Settings
        public  bool          OffensiveCaptions  = false;

        [JsonIgnore]
        private static string _filePath = $"{Program.ModDirectory}\\Settings.json";

        // Extra note.
        private string _descriptions = 
        "\n/*\n" +
        "OffensiveCaptions: Use at own discretion. Enables offensive and extremely vulgar captions to be displayed on Discord.\n" +
        "*/";

        // Read/Write
        public static Settings GetSettings()
        {
            if (! File.Exists(_filePath))
                new Settings().WriteToFile();

            return JsonConvert.DeserializeObject<Settings>(File.ReadAllText(_filePath));
        }

        public void WriteToFile()
        {
            File.WriteAllText(_filePath, JsonConvert.SerializeObject(this, Formatting.Indented) + _descriptions);
        }
    }
}
