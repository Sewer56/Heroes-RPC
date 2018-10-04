using System.Collections.Generic;
using Reloaded_Mod_Template.Heroes.Definitions.Enums;

namespace Reloaded_Mod_Template.Heroes.Utilities
{
    public class StageTranslationDictionary
    {
        /// <summary>
        /// Translates a Shadow The Hedgehog stage id to stage name.
        /// </summary>
        public Dictionary<StageID, string> StageNameTranslator = new Dictionary<StageID, string>(128);

        public StageTranslationDictionary()
        {
            PopulateStageTranslator();
        }

        /// <summary>
        /// Creates a mapping of StageID to string.
        /// </summary>
        private void PopulateStageTranslator()
        {
            StageNameTranslator[StageID.TestLevel]              = "Test Level";

            StageNameTranslator[StageID.SeasideHill]            = "Seaside Hill";
            StageNameTranslator[StageID.OceanPalace]            = "Ocean Palace";
            StageNameTranslator[StageID.GrandMetropolis]        = "Grand Metropolis";
            StageNameTranslator[StageID.PowerPlant]             = "Power Plant";
            StageNameTranslator[StageID.CasinoPark]             = "Casino Park";
            StageNameTranslator[StageID.BingoHighway]           = "Bingo Highway";
            StageNameTranslator[StageID.RailCanyon]             = "Rail Canyon";
            StageNameTranslator[StageID.BulletStation]          = "Bullet Station";
            StageNameTranslator[StageID.FrogForest]             = "Frog Forest";
            StageNameTranslator[StageID.LostJungle]             = "Lost Jungle";
            StageNameTranslator[StageID.HangCastle]             = "Hang Castle";
            StageNameTranslator[StageID.MysticMansion]          = "Mystic Mansion";
            StageNameTranslator[StageID.EggFleet]               = "Egg Fleet";
            StageNameTranslator[StageID.FinalFortress]          = "Final Fortress";

            StageNameTranslator[StageID.EggHawk]                = "Egg Hawk";
            StageNameTranslator[StageID.TeamBattle1]            = "Team Battle 1";
            StageNameTranslator[StageID.TeamBattle2]            = "Team Battle 2";
            StageNameTranslator[StageID.RobotStorm]             = "Robot Storm";
            StageNameTranslator[StageID.EggEmperor]             = "Egg Emperor";
            StageNameTranslator[StageID.MetalMadness]           = "Metal Madness";
            StageNameTranslator[StageID.MetalOverlord]          = "Metal Overlord";

            StageNameTranslator[StageID.SeaGate]                = "Sea Gate";

            StageNameTranslator[StageID.SeasideCourse]          = "Seaside Course (2P)";
            StageNameTranslator[StageID.CityCourse]             = "City Course (2P)";
            StageNameTranslator[StageID.CasinoCourse]           = "Casino Course (2P)";

            StageNameTranslator[StageID.BonusStage1]            = "Bonus Stage 1";
            StageNameTranslator[StageID.BonusStage2]            = "Bonus Stage 2";
            StageNameTranslator[StageID.BonusStage3]            = "Bonus Stage 3";
            StageNameTranslator[StageID.BonusStage4]            = "Bonus Stage 4";
            StageNameTranslator[StageID.BonusStage5]            = "Bonus Stage 5";
            StageNameTranslator[StageID.BonusStage6]            = "Bonus Stage 6";
            StageNameTranslator[StageID.BonusStage7]            = "Bonus Stage 7";

            StageNameTranslator[StageID.SeasideHill2P]          = "Seaside Hill (2P)";
            StageNameTranslator[StageID.GrandMetropolis2P]      = "Grand Metropolis (2P)";
            StageNameTranslator[StageID.BingoHighway2P]         = "Bingo Highway (2P)";

            StageNameTranslator[StageID.CityTopBattle]          = "City Top (2P)";
            StageNameTranslator[StageID.CasinoRingBattle]       = "Casino Ring (2P)";
            StageNameTranslator[StageID.TurtleShellBattle]      = "Turtle Shell (2P)";

            StageNameTranslator[StageID.EggTreat]               = "Egg Treat (2P)";
            StageNameTranslator[StageID.PinballMatch]           = "Pinball Match (2P)";
            StageNameTranslator[StageID.HotElevator]            = "Hot Elevator (2P)";

            StageNameTranslator[StageID.RoadRock]               = "Road Rock (2P)";
            StageNameTranslator[StageID.MadExpress]             = "Mad Express (2P)";
            StageNameTranslator[StageID.TerrorHall]             = "Terror Hall (2P)";

            StageNameTranslator[StageID.RailCanyonExpert]       = "Rail Canyon (2P)";
            StageNameTranslator[StageID.FrogForestExpert]       = "Frog Forest (2P)";
            StageNameTranslator[StageID.EggFleetExpert]         = "Egg Fleet (2P)";

            StageNameTranslator[StageID.EmeraldChallenge1]      = "Emerald Challenge 1";
            StageNameTranslator[StageID.EmeraldChallenge2]      = "Emerald Challenge 2";
            StageNameTranslator[StageID.EmeraldChallenge3]      = "Emerald Challenge 3";
            StageNameTranslator[StageID.EmeraldChallenge4]      = "Emerald Challenge 4";
            StageNameTranslator[StageID.EmeraldChallenge5]      = "Emerald Challenge 5";
            StageNameTranslator[StageID.EmeraldChallenge6]      = "Emerald Challenge 6";
            StageNameTranslator[StageID.EmeraldChallenge7]      = "Emerald Challenge 7";

            StageNameTranslator[StageID.SpecialStageMultiplayer1]   = "Special Stage 1 (2P)";
            StageNameTranslator[StageID.SpecialStageMultiplayer2]   = "Special Stage 2 (2P)";
            StageNameTranslator[StageID.SpecialStageMultiplayer3]   = "Special Stage 3 (2P)";
        }
    }
}
