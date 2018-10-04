using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DiscordRPC;
using Reloaded_Mod_Template.Heroes.Definitions.Enums;

namespace Reloaded_Mod_Template
{
    /// <summary>
    /// Simple easy to use Discord Wrapper.
    /// </summary>
    public unsafe class Discord
    {
        private DiscordRpcClient _client;
        private Heroes.Heroes _heroes;
        private Thread _discordThread;

        /*
            ------------
            Construction
            ------------
        */

        public Discord(Heroes.Heroes heroes)
        {
            Initialize();
            _heroes = heroes;

            _discordThread = new Thread(() =>
            {
                while (true)
                {
                    SetPresence();
                    Thread.Sleep(1000);
                }
            });
            _discordThread.Start();
        }

        private void Initialize()
        {
            // TODO: Insert your Client ID here:
            // Yes; I left mine here - whether you may see this as bad practice or not.
            // While technically; I am not inclined to disclose this as part of the ToS - 
            // the unfortunate reality is that this is very easy to obtain anyway; even if
            // I don't leave it here given the simplicity of decompiling C# code.
            _client = new DiscordRpcClient("494266376899395605");
            _client.Initialize();
        }

        /*
            ------------------
            Core Functionality
            ------------------
        */

        public void SetPresence()
        {
            // Contains the Stage Name
            string currentDetails = GetCurrentDetails();

            // Contains Stage Details
            string currentGameState = GetGameState();

            // Contains the start of current action.
            Timestamps timeStamps = new Timestamps();
            long timeStamp = 0;

            // Images
            Assets assets = new Assets();

            // Set timestamp.
            if ((! _heroes.IsInMainMenu()) && (!_heroes.IsPaused()) && (!_heroes.IsWatchingIngameEvent()))
            {
                // TODO: Bug Here with Seconds

                // Do not set timestamp if paused.
                TimeSpan sinceEpoch = DateTime.UtcNow - new DateTime(1970, 1, 1);
                ;
                timeStamp = (long) (sinceEpoch.TotalSeconds - (*_heroes.CurrentStageTime).GetTotalSeconds());
                timeStamps.Start = Timestamps.FromUnixTime(timeStamp);
            }

            // Get Image
            if (! _heroes.IsInMainMenu())
            {
                if (_heroes.ImageTranslationDictionary.StageNameTranslator.TryGetValue(*_heroes.StageID, out string stageAssetName))
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

        /// <summary>
        /// Gets text set directly under game name on Discord.
        /// </summary>
        private string GetCurrentDetails()
        {
            string currentDetails = "Unknown State";

            if (_heroes.IsPlayingFMV)
                currentDetails = "Watching FMV";

            else if (_heroes.IsWatchingIngameEvent())
                currentDetails = $"Watching Cutscene in {_heroes.GetStageName()}";

            else if (_heroes.IsInMainMenu())
                currentDetails = $"Navigating the Menus";

            else if (_heroes.IsTwoPlayer())
                currentDetails = $"Versus Mode: {_heroes.GetStageName()}";

            else
                currentDetails = $"Playing in {_heroes.GetStageName()}";

            return currentDetails;
        }

        /// <summary>
        /// Retrieves the current state of the game.
        /// </summary>
        private string GetGameState()
        {
            string currentGameState = "";

            // Normal Game (Playing)
            if ((!_heroes.IsWatchingIngameEvent()) && (*_heroes.GameState == GameState.InGame))
            {
                MissionMode missionMode = (**_heroes.GameControlStructPointer).MissionMode;

                switch (missionMode)
                {
                    case MissionMode.HardMode when *_heroes.TeamOne != Team.Sonic:
                        currentGameState = $"Hard Mode, Team {_heroes.GetTeamName(1)}";
                        break;

                    case MissionMode.HardMode:
                        currentGameState = $"Hard Mode";
                        break;

                    case MissionMode.Alternate:
                        currentGameState = $"Team {_heroes.GetTeamName(1)}, Mission II";
                        break;

                    default:
                        currentGameState = $"Team {_heroes.GetTeamName(1)}";
                        break;
                }
            }

            // Two player mode.
            if (_heroes.IsTwoPlayer() && (! _heroes.IsInMainMenu()))
            {
                int total1PVictories = _heroes.VictoryTracker.GetTotalVictoryCount(1);
                int total2PVictories = _heroes.VictoryTracker.GetTotalVictoryCount(2);

                int current1PVictories = _heroes.VictoryTracker.GetVictoryCount(1);
                int current2PVictories = _heroes.VictoryTracker.GetVictoryCount(2);

                string teamName1P = _heroes.GetTeamName(1);
                string teamName2P = _heroes.GetTeamName(2);

                currentGameState = $"Total: {total1PVictories}-{total2PVictories} | {teamName1P} vs {teamName2P} | Set: {current1PVictories}-{current2PVictories}";
            }
                

            // Gameplay Paused
            if (_heroes.IsPaused())
                currentGameState = "Paused";

            return currentGameState;
        }
    }
}
