namespace Reloaded_Mod_Template.Heroes.Definitions.Enums
{
    public enum GameState
    {
        Null = 0,
        Menu = 1,

        // Loading Level
        StartLevelLoad = 2,

        // Displays Titlecard Fadeout
        EndLevelLoad = 3,

        Unknown4 = 4,

        InGame = 5,
        InGamePaused = 6,
        InGamePausedSettings = 7,
        InGamePausedSettingsCamera = 8,
        InGamePausedSettingsRebinding = 9,

        // Fires ACTION::FreezeExec
        InGameSceneFrozen = 10,

        InGameExitWithSave = 11,

        Unknown13Exit = 13,
        InGameLevelWin = 15,
        InGameExit2 = 16,
    }
}
