using System.Collections.Generic;
using Reloaded_Mod_Template.Shadow.Definitions;

namespace Reloaded_Mod_Template.Shadow.Utilities
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
            StageNameTranslator[StageID.TestLevel]               = "Test Level";
            StageNameTranslator[StageID.TestLevelSkatePark]      = "Test Level (Skate Park)";
            StageNameTranslator[StageID.TestLevelUVTextureMap]   = "Test Level (UV Test)";
            StageNameTranslator[StageID.TestLevelSurfaceTest]    = "Test Level (Surface Test)";
            StageNameTranslator[StageID.TestLevelCutsceneTest]   = "Test Level (Cutscene Test)";

            StageNameTranslator[StageID.Westopolis]              = "Westopolis";

            StageNameTranslator[StageID.DigitalCircuit]          = "Digital Circuit";
            StageNameTranslator[StageID.GlyphicCanyon]           = "Glyphic Canyon";
            StageNameTranslator[StageID.LethalHighway]           = "Lethal Highway";

            StageNameTranslator[StageID.LethalHighwayBlackBull]  = "Black Bull (Lethal Highway)";

            StageNameTranslator[StageID.CrypticCastle]           = "Cryptic Castle";
            StageNameTranslator[StageID.PrisonIsland]            = "Prison Island";
            StageNameTranslator[StageID.CircusPark]              = "Circus Park";

            StageNameTranslator[StageID.CrypticCastleEggBreaker] = "Egg Breaker (Cryptic Castle)";

            StageNameTranslator[StageID.CentralCity]             = "Central City";
            StageNameTranslator[StageID.TheDoom]                 = "The Doom";
            StageNameTranslator[StageID.SkyTroops]               = "Sky Troops";
            StageNameTranslator[StageID.MadMatrix]               = "Mad Matrix";
            StageNameTranslator[StageID.DeathRuins]              = "Death Ruins";

            StageNameTranslator[StageID.HeavyDog]                = "Heavy Dog";
            StageNameTranslator[StageID.MadMatrixEggBreaker]     = "Egg Breaker (Mad Matrix)";
            StageNameTranslator[StageID.DeathRuinsBlackBull]     = "Black Bull (Death Ruins)";

            StageNameTranslator[StageID.TheARK]                  = "The ARK";
            StageNameTranslator[StageID.AirFleet]                = "Air Fleet";
            StageNameTranslator[StageID.IronJungle]              = "Iron Jungle";
            StageNameTranslator[StageID.SpaceGadget]             = "Space Gadget";
            StageNameTranslator[StageID.LostImpact]              = "Lost Impact";

            StageNameTranslator[StageID.BlueFalcon]              = "Blue Falcon";
            StageNameTranslator[StageID.IronJungleEggBreaker]    = "Egg Breaker (Iron Jungle)";

            StageNameTranslator[StageID.GUNFortress]             = "GUN Fortress";
            StageNameTranslator[StageID.BlackComet]              = "Black Comet";
            StageNameTranslator[StageID.LavaShelter]             = "Lava Shelter";
            StageNameTranslator[StageID.CosmicFall]              = "Cosmic Fall";
            StageNameTranslator[StageID.FinalHaunt]              = "Final Haunt";

            StageNameTranslator[StageID.GUNFortressBlackDoom]    = "Black Doom (GUN Fortress)";
            StageNameTranslator[StageID.GUNFortressDiablon]      = "Diablon (GUN Fortress)";
            StageNameTranslator[StageID.BlackCometEggDealer]     = "Egg Dealer (Black Comet)";
            StageNameTranslator[StageID.BlackCometDiablon]       = "Diablon (Black Comet)";
            StageNameTranslator[StageID.LavaShelterEggDealer]    = "Egg Dealer (Lava Shelter)";
            StageNameTranslator[StageID.CosmicFallEggDealer]     = "Egg Dealer (Cosmic Fall)";
            StageNameTranslator[StageID.CosmicFallBlackDoom]     = "Black Doom (Cosmic Fall)";
            StageNameTranslator[StageID.FinalHauntBlackDoom]     = "Black Doom (Final Haunt)";
            StageNameTranslator[StageID.FinalHauntDiablon]       = "Diablon (Final Haunt)";

            StageNameTranslator[StageID.TheLastWay]              = "The Last Way";
            StageNameTranslator[StageID.DevilDoom]               = "Devil Doom";

            StageNameTranslator[StageID.TwoPlayerStageOne]       = "2P GUN Fortress A";
            StageNameTranslator[StageID.TwoPlayerStageTwo]       = "2P GUN Fortress B";
            StageNameTranslator[StageID.TwoPlayerStageThree]     = "2P Lava Shelter";

            StageNameTranslator[StageID.RemovedTestLevelSTG6000] = "Removed/Empty Test Level [STG6000]";
            StageNameTranslator[StageID.HeroesAssetsLevel]       = "Heroes Assets Test Level [STG9900] (GameCube Only)";
            StageNameTranslator[StageID.ProtoShadowCreationRoom] = "Prototype Shadow Creation Room [STG9901]";
        }
    }
}
