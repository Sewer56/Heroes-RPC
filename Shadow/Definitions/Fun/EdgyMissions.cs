using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded_Mod_Template.Shadow.Definitions.Fun
{
    public static class EdgyMissions
    {
        // Westopolis
        public const string WestoDark               = "Exterminating the FUCKING humans";
        public const string WestoHero               = "Removing ILLEGAL Aliens from City";
        public const string WestoNeut               = "FUCK'EM ALL, I WANT JEWELS";

        // 200

        // Digital Circuit
        public const string DigitDark               = "FUCKING up the CORE program.";
        public const string DigitHero               = "I like BATS with TITS";

        // Glyphic Canyon
        public const string GlyphDark               = "What the FUCK is THIS temple for!?";
        public const string GlyphNeutral            = "SHINY PRECIOUS JEWELS...";
        public const string GlyphHero               = "Removing ILLEGAL Aliens from TEMPLE (& KNUCKLES)";

        // Lethal Highway
        public const string LethalDark              = "Escaping city like a PUSSY";
        public const string LethalHero              = "FUCKING ALIEN needs his PARKING TICKET";

        // 300

        // Cryptic Castle
        public const string CryptDark               = "Nani da foc u need Lanternz For!?";
        public const string CryptNeutral            = "This place is SPOOPY, Gotta GTFO!";
        public const string CryptHero               = "Showing AFFECTION to FEMALE HEDGEHOG (Gone Sexual)";

        // Prison Island
        public const string PrisonDark              = "FUCKING-OVER HUMANS";
        public const string PrisonNeutral           = "Adding CHAOS TITTY to collection.";
        public const string PrisonHero              = "Collecting TOP SECRET DICKS";

        // Circus park
        public const string CircusDark              = "FUCKING over GUN geeks.";
        public const string CircusNeutral           = "D.A.M.N. FOURTH CHAOS EMERALD";
        public const string CircusHero              = "Making EGGHEAD BANKRUPT";

        // 400

        // Central City
        public const string CityDark                = "7/7 London but Better!";
        public const string CityHero                = "And the fuck I do with Big Bombs!?";

        // The Doom
        public const string DoomDark                = "EXTERMINATING FUCKING humans in SPACE";
        public const string DoomNeutral             = "THIS VIRGIN'S MINE";
        public const string DoomHero                = "SAVING WEAK RESEARCHER PUSSIES";

        // Sky Troops
        public const string SkyDark                 = "BLOWING FUCKING battleships is FUN";
        public const string SkyNeutral              = "Have I seen this FUCKING sky before!?";
        public const string SkyHero                 = "DESTROYING GLOWING BALLZ";

        // Mad Matrix
        public const string MatrixDark              = "DESTROYING HENTAI STASH in TERMINALS";
        public const string MatrixNeutral           = "FUCKING the HENTAI STASH";
        public const string MatrixHero              = "EXTRACTING HENTAI STASH from TERMINALS";

        // Central City
        public const string DeathDark               = "DOOM'S A PUSSY WHEN PINNED";
        public const string DeathHero               = "REMOVING ILLEGAL Aliens from JUNGLE";

        // 500

        // The Ark
        public const string ArkDark                 = "Preparing EARTH for INDEPENDENCE DAY";
        public const string ArkHero                 = "THIS LEVEL IS FUCKING EASY";

        // Air Fleet
        public const string AirDark                 = "FUCKING KILLING WORLD LEADER";
        public const string AirNeutral              = "COLLECTING CHAOS TITTY";
        public const string AirHero                 = "REMOVING ILLEGAL ALIENS FROM SHIP";

        // Iron Jungle
        public const string IronDark                = "GUN are a FUCKING PISS in the ARSE";
        public const string IronNeutral             = "PENETRATING outer perimeter of BASE";
        public const string IronHero                = "THIS AIRSHIP SUCKS ASS";

        // Mad Matrix
        public const string SpaceDark               = "FUCKING DESTROYING THE ARK";
        public const string SpaceNeutral            = "FUCK THIS DUDE; I WANT CHAOS TITTY";
        public const string SpaceHero               = "OWNING THAT FUCKING SLOWPOKE";

        // Lost Impact
        public const string LostDark                = "I DON'T NEED ANY MORE RULE34";
        public const string LostHero                = "Ejaculating Gerald's BLUE JIZZ from ARK";

        // 600

        // GUN Fortress
        public const string GunDark                 = "FUCK THESE FUCKING HUMANS";
        public const string GunHero                 = "BAT TITS > REST OF WORLD";

        // Black Comet
        public const string CometDark               = "FUCKING GUN COCKSUCKERS";
        public const string CometHero               = "ESCAPING JIZZ FILLED COMET";

        // Lava Shelter
        public const string LavaDark                = "BITCH there's no FUCKING GUN benchods here";
        public const string LavaHero                = "CYKA BLYAT you inferior METAL SHIT";

        // Cosmic Fall
        public const string CosmicDark              = "WHO THE FUCK CARES";
        public const string CosmicHero              = "THE COMPUTER ROOM!!";

        // Central City
        public const string HauntDark               = "GIVING THIS PUSSY HIS SHIELDS";
        public const string HauntHero               = "FINDING BLACK ILLEGAL ALIEN";

        /// <summary>
        /// This method is quite ugly. The quality of it is the same as the edginess of this class.
        /// </summary>
        public static string GetEdgyMission(StageID stageId, CurrentMission mission)
        {
            switch (stageId)
            {
                // 100
                case StageID.Westopolis:
                    switch (mission)
                    {
                        case CurrentMission.Dark:   return WestoDark;
                        case CurrentMission.Normal: return WestoNeut;
                        case CurrentMission.Hero:   return WestoHero;
                    };
                    break;
                
                // 200
                case StageID.DigitalCircuit:
                    switch (mission)
                    {
                        case CurrentMission.Dark:   return DigitDark;
                        case CurrentMission.Hero:   return DigitHero;
                    };
                    break;
                case StageID.GlyphicCanyon:
                    switch (mission)
                    {
                        case CurrentMission.Dark:   return GlyphDark;
                        case CurrentMission.Normal: return GlyphNeutral;
                        case CurrentMission.Hero:   return GlyphHero;
                    };
                    break;
                case StageID.LethalHighway:
                    switch (mission)
                    {
                        case CurrentMission.Dark:   return LethalDark;
                        case CurrentMission.Hero:   return LethalHero;
                    };
                    break;


                // 300
                case StageID.CrypticCastle:
                    switch (mission)
                    {
                        case CurrentMission.Dark:   return CryptDark;
                        case CurrentMission.Hero:   return CryptHero;
                    };
                    break;
                case StageID.PrisonIsland:
                    switch (mission)
                    {
                        case CurrentMission.Dark:   return PrisonDark;
                        case CurrentMission.Normal: return PrisonNeutral;
                        case CurrentMission.Hero:   return PrisonHero;
                    };
                    break;
                case StageID.CircusPark:
                    switch (mission)
                    {
                        case CurrentMission.Dark:   return CircusDark;
                        case CurrentMission.Hero:   return CircusHero;
                    };
                    break;

                // 400
                case StageID.CentralCity:
                    switch (mission)
                    {
                        case CurrentMission.Dark:   return CityDark;
                        case CurrentMission.Hero:   return CityHero;
                    };
                    break;
                case StageID.TheDoom:
                    switch (mission)
                    {
                        case CurrentMission.Dark:   return DoomDark;
                        case CurrentMission.Normal: return DoomNeutral;
                        case CurrentMission.Hero:   return DoomHero;
                    };
                    break;
                case StageID.SkyTroops:
                    switch (mission)
                    {
                        case CurrentMission.Dark:   return SkyDark;
                        case CurrentMission.Normal: return SkyNeutral;
                        case CurrentMission.Hero:   return SkyHero;
                    };
                    break;
                case StageID.MadMatrix:
                    switch (mission)
                    {
                        case CurrentMission.Dark:   return MatrixDark;
                        case CurrentMission.Normal: return MatrixNeutral;
                        case CurrentMission.Hero:   return MatrixHero;
                    };
                    break;
                case StageID.DeathRuins:
                    switch (mission)
                    {
                        case CurrentMission.Dark:   return DeathDark;
                        case CurrentMission.Hero:   return DeathHero;
                    };
                    break;

                // 500
                case StageID.TheARK:
                    switch (mission)
                    {
                        case CurrentMission.Dark:   return ArkDark;
                        case CurrentMission.Hero:   return ArkHero;
                    };
                    break;
                case StageID.AirFleet:
                    switch (mission)
                    {
                        case CurrentMission.Dark:   return AirDark;
                        case CurrentMission.Normal: return AirNeutral;
                        case CurrentMission.Hero:   return AirHero;
                    };
                    break;
                case StageID.IronJungle:
                    switch (mission)
                    {
                        case CurrentMission.Dark:   return IronDark;
                        case CurrentMission.Normal: return IronNeutral;
                        case CurrentMission.Hero:   return IronHero;
                    };
                    break;
                case StageID.SpaceGadget:
                    switch (mission)
                    {
                        case CurrentMission.Dark:   return SpaceDark;
                        case CurrentMission.Normal: return SpaceNeutral;
                        case CurrentMission.Hero:   return SpaceHero;
                    };
                    break;
                case StageID.LostImpact:
                    switch (mission)
                    {
                        case CurrentMission.Dark:   return LostDark;
                        case CurrentMission.Hero:   return LostHero;
                    };
                    break;

                // 600
                case StageID.GUNFortress:
                    switch (mission)
                    {
                        case CurrentMission.Dark:   return GunDark;
                        case CurrentMission.Hero:   return GunHero;
                    };
                    break;
                case StageID.BlackComet:
                    switch (mission)
                    {
                        case CurrentMission.Dark:   return CometDark;
                        case CurrentMission.Hero:   return CometHero;
                    };
                    break;
                case StageID.LavaShelter:
                    switch (mission)
                    {
                        case CurrentMission.Dark:   return LavaDark;
                        case CurrentMission.Hero:   return LavaHero;
                    };
                    break;
                case StageID.CosmicFall:
                    switch (mission)
                    {
                        case CurrentMission.Dark:   return CosmicDark;
                        case CurrentMission.Hero:   return CosmicHero;
                    };
                    break;
                case StageID.FinalHaunt:
                    switch (mission)
                    {
                        case CurrentMission.Dark:   return HauntDark;
                        case CurrentMission.Hero:   return HauntHero;
                    };
                    break;
            }

            return "";
        }
    }
}
