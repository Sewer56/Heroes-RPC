using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Reloaded_Mod_Template.Shadow.Definitions;
using Reloaded_Mod_Template.Shadow.Utilities;

namespace Reloaded_Mod_Template.Shadow
{
    /// <summary>
    /// Utility methods for Shadow the Hedgehog Dolphin game process.
    /// </summary>
    public unsafe class Shadow
    {
        /* Pointers */
        private const long GameIDPointer = 0x80000000;
        private const long StagePointer = 0x805EF958;
        private const long MenuPointer = 0x80583ACC;
        private const long CurrentModePointer = 0x805EC170;
        private const long CurrentMissionPointer = 0x80575F1F;
        private const long GameplayFreezedPointer = 0x8057D768; // (Freezes all gameplay objects, including timer)
                                                                // Use to check if paused.
        private const long IsCutsceneEnabledPointer = 0x8057FA85;
        private const long CurrentTimerFloatPointer = 0x8057D734;

        /* Members */

        public StageTranslationDictionary StageTranslationDictionary { get; set; } = new StageTranslationDictionary();
        public MenuTranslationDictionary  MenuTranslationDictionary { get; set; } = new MenuTranslationDictionary();
        public ModeTranslationDictionary ModeTranslationDictionary { get; set; } = new ModeTranslationDictionary();
        public ImageTranslationDictionary ImageTranslationDictionary { get; set; } = new ImageTranslationDictionary();
        public Dolphin Dolphin { get; set; }

        /* Properties */
        public StageID Stage
        {
            get
            {
                var address = Dolphin.ConvertMemoryAddress(StagePointer);
                var stageListPtr = (StageID*)address;
                return (StageID) EndianConverter.ReverseEndian((int)(*stageListPtr));
            }
            set
            {
                var address = Dolphin.ConvertMemoryAddress(StagePointer);
                var stageListPtr = (StageID*)address;
                *stageListPtr = (StageID)EndianConverter.ReverseEndian((int)(value));
            }
        }

        public MenuState MenuState
        {
            get
            {
                var address = Dolphin.ConvertMemoryAddress(MenuPointer);
                var menuStatePtr = (MenuState*)address;
                return (MenuState)EndianConverter.ReverseEndian((int)(*menuStatePtr));
            }
            set
            {
                var address = Dolphin.ConvertMemoryAddress(MenuPointer);
                var menuStatePtr = (MenuState*)address;
                *menuStatePtr = (MenuState)EndianConverter.ReverseEndian((int)(value));
            }
        }

        public Modes CurrentMode
        {
            get
            {
                var address = Dolphin.ConvertMemoryAddress(CurrentModePointer);
                var currentModePtr = (Modes*)address;
                return (Modes)EndianConverter.ReverseEndian((int)(*currentModePtr));
            }
            set
            {
                var address = Dolphin.ConvertMemoryAddress(CurrentModePointer);
                var curentModePtr = (Modes*)address;
                *curentModePtr = (Modes)EndianConverter.ReverseEndian((int)(value));
            }
        }

        public CurrentMission CurrentMission
        {
            // CurrentMission is a byte, no endian swapping here.
            get
            {
                var address = Dolphin.ConvertMemoryAddress(CurrentMissionPointer);
                var currentMissionPtr = (CurrentMission*)address;
                return *currentMissionPtr;
            }
            set
            {
                var address = Dolphin.ConvertMemoryAddress(CurrentMissionPointer);
                var currentMissionPtr = (CurrentMission*)address;
                *currentMissionPtr = value;
            }
        }

        public byte IsWatchingCutscene
        {
            get
            {
                var address = Dolphin.ConvertMemoryAddress(IsCutsceneEnabledPointer);
                var isWatchingCutscenePtr = (byte*)address;
                return *isWatchingCutscenePtr;
            }
            set
            {
                var address = Dolphin.ConvertMemoryAddress(IsCutsceneEnabledPointer);
                var isWatchingCutscenePtr = (byte*)address;
                *isWatchingCutscenePtr = value;
            }
        }

        public byte IsGameplayFreezed
        {
            get
            {
                var address = Dolphin.ConvertMemoryAddress(GameplayFreezedPointer);
                var gameplayFreezedPointer = (byte*)address;
                return *gameplayFreezedPointer;
            }
            set
            {
                var address = Dolphin.ConvertMemoryAddress(GameplayFreezedPointer);
                var gameplayFreezedPointer = (byte*)address;
                *gameplayFreezedPointer = value;
            }
        }

        public float StageTimer
        {
            get
            {
                var address = Dolphin.ConvertMemoryAddress(CurrentTimerFloatPointer);
                var stageTimerPtr = (float*)address;
                return (float)EndianConverter.ReverseEndian(*stageTimerPtr);
            }
            set
            {
                var address = Dolphin.ConvertMemoryAddress(CurrentTimerFloatPointer);
                var stageTimerPtr = (float*)address;
                *stageTimerPtr = (float)EndianConverter.ReverseEndian(value);
            }
        }


        /*
            ------------
            Construction
            ------------
        */

        public Shadow(Dolphin dolphin)
        {
            Dolphin = dolphin;
        }


        /*
            ---------------
            Utility Methods
            ---------------
        */

        [HandleProcessCorruptedStateExceptions]
        public bool IsPlayingShadow()
        {
            Dolphin.UpdateDolphinBaseAddress();
            if (Dolphin.ValidBaseAddress)
            {
                var gameIdPointer = Dolphin.ConvertMemoryAddress(GameIDPointer);
                var gameId = Marshal.PtrToStringAnsi(gameIdPointer, 6);
                if (gameId == "GUPE8P")
                    return true;
            }

            return false;
        }

        public string GetStageName()
        {
            if (StageTranslationDictionary.StageNameTranslator.TryGetValue(Stage, out string stageName))
                return stageName;
            else
                return "Cutscene or Unknown Stage";
        }

        public string GetMenuStateName()
        {
            if (MenuTranslationDictionary.MenuNameTranslator.TryGetValue(MenuState, out string menuState))
                return menuState;
            else
                return "Unknown Menu State";
        }

        public string GetModeName()
        {
            if (ModeTranslationDictionary.ModeNameTranslator.TryGetValue(CurrentMode, out string modeState))
                return modeState;
            else
                return "Unknown Mode";
        }

        public string GetCurrentMission()
        {
            return CurrentMission.ToString("G");
        }
    }
}
