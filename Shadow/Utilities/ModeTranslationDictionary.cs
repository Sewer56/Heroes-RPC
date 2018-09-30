using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reloaded_Mod_Template.Shadow.Definitions;

namespace Reloaded_Mod_Template.Shadow.Utilities
{
    public class ModeTranslationDictionary
    {
        /// <summary>
        /// Translates a Shadow The Hedgehog stage id to stage name.
        /// </summary>
        public Dictionary<Modes, string> ModeNameTranslator = new Dictionary<Modes, string>(128);

        public ModeTranslationDictionary()
        {
            PopulateModeTranslator();
        }

        private void PopulateModeTranslator()
        {
            ModeNameTranslator[Modes.Menu]                = "In-Menu";
            ModeNameTranslator[Modes.ExpertMode]          = "Expert Mode";
            ModeNameTranslator[Modes.StoryMode]           = "Story Mode";
            ModeNameTranslator[Modes.TwoPlayer]           = "Two Player";
            ModeNameTranslator[Modes.SelectMode]          = "Select Mode";
        }
    }
}
