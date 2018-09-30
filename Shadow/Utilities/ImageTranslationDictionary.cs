using System.Collections.Generic;
using Reloaded_Mod_Template.Shadow.Definitions;

namespace Reloaded_Mod_Template.Shadow.Utilities
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
            StageNameTranslator[StageID.TestLevel]               = "stg0000";
            StageNameTranslator[StageID.TestLevelSkatePark]      = "stg0001";
            StageNameTranslator[StageID.TestLevelUVTextureMap]   = "stg0003";
            StageNameTranslator[StageID.TestLevelSurfaceTest]    = "stg0002";
            StageNameTranslator[StageID.TestLevelCutsceneTest]   = "stg0005";

            StageNameTranslator[StageID.Westopolis]              = "westopolis";

            StageNameTranslator[StageID.DigitalCircuit]          = "digitalcircuit";
            StageNameTranslator[StageID.GlyphicCanyon]           = "glyphiccanyon";
            StageNameTranslator[StageID.LethalHighway]           = "lethalhighway";

            StageNameTranslator[StageID.LethalHighwayBlackBull]  = "lethalhighwayblackbull";

            StageNameTranslator[StageID.CrypticCastle]           = "crypticcastle";
            StageNameTranslator[StageID.PrisonIsland]            = "prisonisland";
            StageNameTranslator[StageID.CircusPark]              = "circuspark";

            StageNameTranslator[StageID.CrypticCastleEggBreaker] = "crypticcastleeggdealer";

            StageNameTranslator[StageID.CentralCity]             = "centralcity";
            StageNameTranslator[StageID.TheDoom]                 = "thedoom";
            StageNameTranslator[StageID.SkyTroops]               = "skytroops";
            StageNameTranslator[StageID.MadMatrix]               = "madmatrix";
            StageNameTranslator[StageID.DeathRuins]              = "deathruins";

            StageNameTranslator[StageID.HeavyDog]                = "thedoombluefalcon";
            StageNameTranslator[StageID.MadMatrixEggBreaker]     = "madmatrixeggbreaker";
            StageNameTranslator[StageID.DeathRuinsBlackBull]     = "deathruinsblackbull";

            StageNameTranslator[StageID.TheARK]                  = "theark";
            StageNameTranslator[StageID.AirFleet]                = "airfleet";
            StageNameTranslator[StageID.IronJungle]              = "ironjungle";
            StageNameTranslator[StageID.SpaceGadget]             = "spacegadget";
            StageNameTranslator[StageID.LostImpact]              = "lostimpact";

            StageNameTranslator[StageID.BlueFalcon]              = "thearkbluefalcon";
            StageNameTranslator[StageID.IronJungleEggBreaker]    = "ironfleeteggbreaker";

            StageNameTranslator[StageID.GUNFortress]             = "gunfortress";
            StageNameTranslator[StageID.BlackComet]              = "blackcomet";
            StageNameTranslator[StageID.LavaShelter]             = "lavashelter";
            StageNameTranslator[StageID.CosmicFall]              = "cosmicfall";
            StageNameTranslator[StageID.FinalHaunt]              = "finalhaunt";

            StageNameTranslator[StageID.GUNFortressBlackDoom]    = "gunfortressdoom";
            StageNameTranslator[StageID.GUNFortressDiablon]      = "gunfortressdiablon";
            StageNameTranslator[StageID.BlackCometEggDealer]     = "blackcometeggdealer";
            StageNameTranslator[StageID.BlackCometDiablon]       = "blackcometdiablon";
            StageNameTranslator[StageID.LavaShelterEggDealer]    = "lavasheltereggdealer";
            StageNameTranslator[StageID.CosmicFallEggDealer]     = "cosmicfalleggdealer";
            StageNameTranslator[StageID.CosmicFallBlackDoom]     = "cosmicfallblackdoom";
            StageNameTranslator[StageID.FinalHauntBlackDoom]     = "finalhauntdoom";
            StageNameTranslator[StageID.FinalHauntDiablon]       = "finalhauntdiablon";

            StageNameTranslator[StageID.TheLastWay]              = "thelastway";
            StageNameTranslator[StageID.DevilDoom]               = "devildoom";
            StageNameTranslator[StageID.HeroesAssetsLevel]       = "stg9900";
        }
    }
}
