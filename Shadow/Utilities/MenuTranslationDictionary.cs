using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reloaded_Mod_Template.Shadow.Definitions;

namespace Reloaded_Mod_Template.Shadow.Utilities
{
    public class MenuTranslationDictionary
    {
        /// <summary>
        /// Translates a Shadow The Hedgehog stage id to stage name.
        /// </summary>
        public Dictionary<MenuState, string> MenuNameTranslator = new Dictionary<MenuState, string>(128);

        public MenuTranslationDictionary()
        {
            PopulateMenuTranslator();
        }

        private void PopulateMenuTranslator()
        {
            MenuNameTranslator[MenuState.InGame]                = "In-Game";
            MenuNameTranslator[MenuState.MainMenu]              = "Main Menu";
            MenuNameTranslator[MenuState.Options]               = "Adjusting Options";

            MenuNameTranslator[MenuState.StoryAndLibrary]       = "Story Menu";
            MenuNameTranslator[MenuState.LibraryMusic]          = "Chillin' in the Library";
            MenuNameTranslator[MenuState.StoryRecap]            = "Looking at Boring Shadow Monologue";

            MenuNameTranslator[MenuState.SelectMode]            = "Picking a Stage!";
            MenuNameTranslator[MenuState.TwoPlayer]             = "Setting up Two Player with a Buddy!";

            MenuNameTranslator[MenuState.OpeningMovie]          = "Watching Movie";
            MenuNameTranslator[MenuState.BootMessage]           = "Message Dialog";
            MenuNameTranslator[MenuState.Logos]                 = "Looking at Cool Logos";
        }
    }
}
