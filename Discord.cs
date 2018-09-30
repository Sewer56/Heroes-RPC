using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DiscordRPC;
using Reloaded_Mod_Template.Shadow.Definitions;

namespace Reloaded_Mod_Template
{
    /// <summary>
    /// Simple easy to use Discord Wrapper.
    /// </summary>
    public class Discord
    {
        private DiscordRpcClient _client;
        private Shadow.Shadow _shadow;
        private Settings _settings;
        private Thread _discordThread;

        /*
            ------------
            Construction
            ------------
        */

        public Discord(Shadow.Shadow shadow, Settings settings)
        {
            Initialize();
            _shadow = shadow;
            _settings = settings;

            _discordThread = new Thread(() =>
            {
                while (true)
                {
                    SetPresence();
                    Thread.Sleep(5000);
                }
            });
            _discordThread.Start();
        }

        private void Initialize()
        {
            _client = new DiscordRpcClient("493507183749627907");
            _client.Initialize();
        }

        /*
            ------------------
            Core Functionality
            ------------------
        */

        public void SetPresence()
        {
            if (_shadow.IsPlayingShadow())
            {
                // Contains the Stage Name
                string currentDetails = "";

                // Contains Stage Details
                string currentGameState = "";

                // Contains the start of current action.
                Timestamps timeStamps = new Timestamps();
                long timeStamp = 0;

                // Images
                Assets assets = new Assets();

                // Set Game Details
                if (_shadow.IsWatchingCutscene == 1)
                    currentDetails = "Watching Cutscene";
                else if (_shadow.CurrentMode == Modes.Menu)
                    currentDetails = "Navigating Menus";
                else
                    currentDetails = _shadow.GetStageName();

                // Set Game State
                if (_settings.OffensiveCaptions && _shadow.CurrentMode != Modes.ExpertMode)
                {
                    // Edgy Text
                    currentGameState = $"{Shadow.Definitions.Fun.EdgyMissions.GetEdgyMission(_shadow.Stage, _shadow.CurrentMission)}";
                }
                else
                {
                    // Normal Game
                    if ((_shadow.IsWatchingCutscene == 0) && (_shadow.CurrentMode != Modes.Menu))
                        currentGameState = $"[{_shadow.GetModeName()}] {_shadow.GetCurrentMission()}";

                    // Override if Expert Mode
                    if ((_shadow.IsWatchingCutscene == 0) && (_shadow.CurrentMode == Modes.ExpertMode))
                        currentGameState = $"{_shadow.GetModeName()}";

                    // Menus
                    if (_shadow.CurrentMode == Modes.Menu)
                        currentGameState = $"{_shadow.GetMenuStateName()}";

                    // Gameplay Paused
                    if (_shadow.IsGameplayFreezed == 1)
                        currentGameState = "Paused";
                }

                // Set timestamp.
                if (_shadow.MenuState == MenuState.InGame && (_shadow.IsGameplayFreezed == 0))
                {
                    // Do not set timestamp if paused.
                    TimeSpan sinceEpoch = DateTime.UtcNow - new DateTime(1970, 1, 1); ;
                    timeStamp = (long)(sinceEpoch.TotalSeconds - _shadow.StageTimer);
                    timeStamps.Start = Timestamps.FromUnixTime(timeStamp);
                }

                // Get Image
                if (_shadow.MenuState == MenuState.InGame)
                {
                    if (_shadow.ImageTranslationDictionary.StageNameTranslator.TryGetValue(_shadow.Stage, out string stageAssetName))
                    {
                        assets.LargeImageKey = stageAssetName;
                    }
                }

                // Send to Discord
                _client.SetPresence(new RichPresence()
                {
                    Details = currentDetails,
                    Timestamps = timeStamps,
                    State = currentGameState,
                    Assets = assets
                });
            }
        }
    }
}
