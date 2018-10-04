using System;
using Reloaded_Mod_Template.Heroes.Definitions.Enums;

namespace Reloaded_Mod_Template.Heroes.Utilities
{
    public class StageTagger
    {
        /// <summary>
        /// Defines individual stage properties for each stage in question.
        /// These properties are our own, custom defined and exist to simply help us classify individual levels.
        /// </summary>
        [Flags]
        public enum StageTag
        {
            /// <summary>
            /// The stage is either a team battle stage, enemy rush or a boss stage.
            /// </summary>
            Battle = 1,

            /// <summary>
            /// The stage is a tutorial stage.
            /// </summary>
            Tutorial = 2,

            /// <summary>
            /// The stage is a bobsled race stage.
            /// </summary>
            Bobsled = 4,

            /// <summary>
            /// The stage is a bonus stage.
            /// </summary>
            Bonus = 8,

            /// <summary>
            /// This stage is a special stage.
            /// </summary>
            Special = 16,

            /// <summary>
            /// This stage is exclusive to an individual team.
            /// </summary>
            Exclusive = 32,

            /// <summary>
            /// This stage is a Two Player stage.
            /// </summary>
            TwoPlayer = 64,

            /// <summary>
            /// This stage is a ring race.
            /// </summary>
            RingRace = 128
        }

        /// <summary>
        /// Converts an individual stage ID (number in RAM) into a set of tags which categorize the individual stage.
        /// </summary>
        /// <param name="stageId">The stage ID for the individual stage.</param>
        /// <returns>A list of individual tags for a stage.</returns>
        public StageTag CategorizeStage(int stageId)
        {
            // Set default tag.
            StageTag stageTag = 0;

            // Exclusive Stages
            if (stageId == (int)StageID.TestLevel || stageId == (int)StageID.RailCanyonChaotix)
                stageTag |= StageTag.Exclusive;

            // Battle Stages
            if (IsBetween(stageId, (int)StageID.EggHawk, (int)StageID.MetalOverlord) ||
                IsBetween(stageId, (int)StageID.CityTopBattle, (int)StageID.TurtleShellBattle))
                stageTag |= StageTag.Battle;

            // Tutorial Stage
            if (stageId == (int)StageID.SeaGate)
                stageTag |= StageTag.Tutorial;

            // Bobsled Stage
            if (IsBetween(stageId, (int)StageID.SeasideCourse, (int)StageID.CasinoCourse))
                stageTag |= StageTag.Bobsled;

            // Bonus Stage
            if (IsBetween(stageId, (int)StageID.BonusStage1, (int)StageID.BonusStage7))
                stageTag |= StageTag.Bonus;

            // Two Player
            if (IsBetween(stageId, (int)StageID.SeasideHill2P, (int)StageID.EggFleetExpert) ||
                IsBetween(stageId, (int)StageID.SeasideCourse, (int)StageID.CasinoCourse) ||
                IsBetween(stageId, (int)StageID.SpecialStageMultiplayer1, (int)StageID.SpecialStageMultiplayer3))
                stageTag |= StageTag.TwoPlayer;

            // Special Stage
            if (IsBetween(stageId, (int)StageID.EmeraldChallenge1, (int)StageID.EmeraldChallenge7) ||
                IsBetween(stageId, (int)StageID.SpecialStageMultiplayer1, (int)StageID.SpecialStageMultiplayer3))
                stageTag |= StageTag.Special;

            return stageTag;
        }

        /// <summary>
        /// Checks whether a number lies between a certain range of numbers (inclusive).
        /// </summary>
        /// <param name="value">The number to compare.</param>
        /// <param name="minimum">The minimum value to check.</param>
        /// <param name="maximum">The maximum value to check.</param>
        /// <returns>The number</returns>
        private static bool IsBetween(int value, int minimum, int maximum)
        {
            return value >= minimum && value <= maximum;
        }
    }
}
