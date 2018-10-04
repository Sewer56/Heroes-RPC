using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using Reloaded.Process.Functions.X86Functions;
using Reloaded.Process.Functions.X86Hooking;
using Reloaded_Mod_Template.Heroes.Definitions;
using Reloaded_Mod_Template.Heroes.Definitions.Enums;
using Reloaded_Mod_Template.Heroes.Utilities;

namespace Reloaded_Mod_Template.Heroes
{
    /// <summary>
    /// Utility methods for Shadow the Hedgehog Dolphin game process.
    /// </summary>
    public unsafe class Heroes
    {
        /* Pointers */
        public StageID*     StageID     = (StageID*)    0x008D6710;
        public GameState*   GameState   = (GameState*)  0x008D66F0;

        public Team* TeamOne            = (Team*) 0x8D6920;
        public Team* TeamTwo            = (Team*) 0x8D6924;
        public Team* TeamThree          = (Team*) 0x8D6928;
        public Team* TeamFour           = (Team*) 0x8D692C;

        public int*  NumberOfCameras    = (int*) 0xA60BE4;
        public SomeGameControlStruct** GameControlStructPointer = (SomeGameControlStruct**) 0x00A777E4;

        public Time* CurrentStageTime       = (Time*) 0x009DD708;

        private int** _someEventPointer = (int**)0x00A776EC;
        
        /* Members */
        public bool IsPlayingFMV = false;

        /* Members */
        public StageTranslationDictionary   StageTranslationDictionary  { get; set; } = new StageTranslationDictionary();
        public TeamTranslationDictionary    ModeTranslationDictionary   { get; set; } = new TeamTranslationDictionary();
        public ImageTranslationDictionary   ImageTranslationDictionary  { get; set; } = new ImageTranslationDictionary();
        public StageTagger                  StageTagger                 { get; set; } = new StageTagger();
        public VictoryTracker               VictoryTracker              { get; set; } = new VictoryTracker();

        /*
            ---------------
            Utility Methods
            ---------------
        */

        public bool IsTwoPlayer()
        {
            return *TeamTwo != Team.Null;
        }

        public int GetPlayerCount()
        {
            if (*TeamFour != Team.Null)
                return 4;

            if (*TeamThree != Team.Null)
                return 3;

            if (*TeamTwo != Team.Null)
                return 2;

            return 1;
        }

        public StageTagger.StageTag GetStageTags()
        {
            return StageTagger.CategorizeStage((int)(*StageID));
        }

        public string GetStageName()
        {
            if (StageTranslationDictionary.StageNameTranslator.TryGetValue(*StageID, out string stageName))
                return stageName;
            else
                return "Custom Stage";
        }

        /// <summary>
        /// PlayerNumber has range 1-4.
        /// </summary>
        public string GetTeamName(int playerNumber)
        {
            Team currentTeam = Team.Null;
            if (playerNumber == 1) { currentTeam = *TeamOne; }
            if (playerNumber == 2) { currentTeam = *TeamTwo; }
            if (playerNumber == 3) { currentTeam = *TeamThree; }
            if (playerNumber == 4) { currentTeam = *TeamFour; }

            if (ModeTranslationDictionary.TeamNameTranslator.TryGetValue(currentTeam, out string modeState))
                return modeState;
            else
                return "Unknown Team";
        }

        public bool IsWatchingIngameEvent()
        {
            return ((CurrentStageTime[0].Seconds == 0) && (CurrentStageTime[0].Minutes == 0) && *_someEventPointer != (void*)0 && !IsInMainMenu());
        }

        public bool IsPaused()
        {
            GameState gameState = *GameState;

            switch (gameState)
            {
                case Definitions.Enums.GameState.InGamePaused:
                case Definitions.Enums.GameState.InGamePausedSettings:
                case Definitions.Enums.GameState.InGamePausedSettingsCamera:
                case Definitions.Enums.GameState.InGamePausedSettingsRebinding:
                    return true;
            }

            return false;
        }

        public bool IsInMainMenu()
        {
            return *GameState == Definitions.Enums.GameState.Menu || *GameState == Definitions.Enums.GameState.Null;
        }

        /*
            -----
            Hooks
            -----
        */

        private FunctionHook<MOVIE_PLAY> _moviePlayHook;
        private FunctionHook<MOVIE_END> _movieEndHook;

        // Constructor
        public Heroes()
        {
            _moviePlayHook = FunctionHook<MOVIE_PLAY>.Create(0x00643DE0, MoviePlayImpl).Activate();
            _movieEndHook  = FunctionHook<MOVIE_END>.Create(0x00643E00, MovieEndImpl).Activate();
        }

        private int MoviePlayImpl(int* thispointer)
        {
            IsPlayingFMV = true;
            return _moviePlayHook.OriginalFunction(thispointer);
        }

        private int MovieEndImpl()
        {
            IsPlayingFMV = false;
            return _movieEndHook.OriginalFunction();
        }

        [ReloadedFunction(CallingConventions.MicrosoftThiscall)]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int MOVIE_PLAY(int* thisPointer); // 00643DE0

        [ReloadedFunction(CallingConventions.Cdecl)]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int MOVIE_END(); // 00643E00 
    }
}
