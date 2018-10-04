using Reloaded_Mod_Template.Heroes.Definitions.Enums;
using System.Collections.Generic;

namespace Reloaded_Mod_Template.Heroes.Utilities
{
    public class TeamTranslationDictionary
    {
        /// <summary>
        /// Translates a Shadow The Hedgehog stage id to stage name.
        /// </summary>
        public Dictionary<Team, string> TeamNameTranslator = new Dictionary<Team, string>(128);

        public TeamTranslationDictionary()
        {
            PopulateModeTranslator();
        }

        private void PopulateModeTranslator()
        {
            TeamNameTranslator[Team.Sonic]      = "Sonic";
            TeamNameTranslator[Team.Dark]       = "Dark";
            TeamNameTranslator[Team.Chaotix]    = "Chaotix";
            TeamNameTranslator[Team.Rose]       = "Rose";
            TeamNameTranslator[Team.ForEDIT]    = "Foredit";
        }
    }
}
