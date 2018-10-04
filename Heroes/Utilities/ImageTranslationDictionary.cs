using System.Collections.Generic;
using Reloaded_Mod_Template.Heroes.Definitions;
using Reloaded_Mod_Template.Heroes.Definitions.Enums;

namespace Reloaded_Mod_Template.Heroes.Utilities
{
    public class ImageTranslationDictionary
    {
        /// <summary>
        /// Translates a Shadow The Hedgehog stage id to stage image.
        /// </summary>
        public Dictionary<StageID, string> StageNameTranslator = new Dictionary<StageID, string>(128);

        public ImageTranslationDictionary()
        {
            PopulateImageTranslator();
        }

        /// <summary>
        /// Creates a mapping of StageID to string.
        /// </summary>
        private void PopulateImageTranslator()
        {
            StageNameTranslator[StageID.TestLevel]              = "testlevel";

            StageNameTranslator[StageID.SeasideHill]            = "seasidehill";
            StageNameTranslator[StageID.OceanPalace]            = "oceanpalace";
            StageNameTranslator[StageID.GrandMetropolis]        = "grandmetropolis";
            StageNameTranslator[StageID.PowerPlant]             = "powerplant";
            StageNameTranslator[StageID.CasinoPark]             = "casinopark";
            StageNameTranslator[StageID.BingoHighway]           = "bingohighway";
            StageNameTranslator[StageID.RailCanyon]             = "railcanyon";
            StageNameTranslator[StageID.BulletStation]          = "bulletstation";
            StageNameTranslator[StageID.FrogForest]             = "frogforest";
            StageNameTranslator[StageID.LostJungle]             = "lostjungle";
            StageNameTranslator[StageID.HangCastle]             = "hangcastle";
            StageNameTranslator[StageID.MysticMansion]          = "mysticmansion";
            StageNameTranslator[StageID.EggFleet]               = "eggfleet";
            StageNameTranslator[StageID.FinalFortress]          = "finalfortress";

            StageNameTranslator[StageID.EggHawk]                = "egghawk";
            StageNameTranslator[StageID.TeamBattle1]            = "teambattle1";
            StageNameTranslator[StageID.TeamBattle2]            = "teambattle2";
            StageNameTranslator[StageID.RobotStorm]             = "robotstorm";
            StageNameTranslator[StageID.EggEmperor]             = "eggemperor";
            StageNameTranslator[StageID.MetalMadness]           = "metalmadness";
            StageNameTranslator[StageID.MetalOverlord]          = "metaloverlord";

            StageNameTranslator[StageID.SeaGate]                = "seagate";

            StageNameTranslator[StageID.SeasideCourse]          = "seasidecourse";
            StageNameTranslator[StageID.CityCourse]             = "citycourse";
            StageNameTranslator[StageID.CasinoCourse]           = "casinocourse";

            StageNameTranslator[StageID.BonusStage1]            = "bonusstage1";
            StageNameTranslator[StageID.BonusStage2]            = "bonusstage2";
            StageNameTranslator[StageID.BonusStage3]            = "bonusstage3";
            StageNameTranslator[StageID.BonusStage4]            = "bonusstage4";
            StageNameTranslator[StageID.BonusStage5]            = "bonusstage5";
            StageNameTranslator[StageID.BonusStage6]            = "bonusstage6";
            StageNameTranslator[StageID.BonusStage7]            = "bonusstage7";

            StageNameTranslator[StageID.SeasideHill2P]          = "seasidehill2p";
            StageNameTranslator[StageID.GrandMetropolis2P]      = "grandmetropolis";
            StageNameTranslator[StageID.BingoHighway2P]         = "bingohighway";

            StageNameTranslator[StageID.CityTopBattle]          = "citytop";
            StageNameTranslator[StageID.CasinoRingBattle]       = "casinoring";
            StageNameTranslator[StageID.TurtleShellBattle]      = "turtleshell";

            StageNameTranslator[StageID.EggTreat]               = "eggtreat";
            StageNameTranslator[StageID.PinballMatch]           = "pinballmatch";
            StageNameTranslator[StageID.HotElevator]            = "hotelevator";

            StageNameTranslator[StageID.RoadRock]               = "roadrock";
            StageNameTranslator[StageID.MadExpress]             = "madexpress";
            StageNameTranslator[StageID.TerrorHall]             = "terrorhall";

            StageNameTranslator[StageID.RailCanyonExpert]       = "railcanyon";
            StageNameTranslator[StageID.FrogForestExpert]       = "frogforest";
            StageNameTranslator[StageID.EggFleetExpert]         = "eggfleet";

            StageNameTranslator[StageID.EmeraldChallenge1]      = "bonusstage1";
            StageNameTranslator[StageID.EmeraldChallenge2]      = "bonusstage2";
            StageNameTranslator[StageID.EmeraldChallenge3]      = "bonusstage3";
            StageNameTranslator[StageID.EmeraldChallenge4]      = "bonusstage4";
            StageNameTranslator[StageID.EmeraldChallenge5]      = "bonusstage5";
            StageNameTranslator[StageID.EmeraldChallenge6]      = "bonusstage6";
            StageNameTranslator[StageID.EmeraldChallenge7]      = "bonusstage7";

            StageNameTranslator[StageID.SpecialStageMultiplayer1] = "bonusstage1";
            StageNameTranslator[StageID.SpecialStageMultiplayer2] = "bonusstage4";
            StageNameTranslator[StageID.SpecialStageMultiplayer3] = "bonusstage7";
        }
    }
}
