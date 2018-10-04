using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded_Mod_Template.Heroes
{
    public struct Time
    {
        public byte Frames;
        public byte Seconds;
        public byte Minutes;

        /// <summary>
        /// Converts the <see cref="Frames"/> field to milliseconds.
        /// </summary>
        public float FramesAsMilliseconds()
        {
            return ((Frames / 60F) * 1000F);
        }

        /// <summary>
        /// Converts the <see cref="Seconds"/> field to milliseconds.
        /// </summary>
        public float SecondsAsMilliseconds()
        {
            return (Seconds * 1000F);
        }

        /// <summary>
        /// Converts the <see cref="Minutes"/> field to milliseconds.
        /// </summary>
        public float MinutesAsMilliseconds()
        {
            return ((Minutes * 60F) * 1000F);
        }

        /// <summary>
        /// Gets complete milliseconds elapsed since zero.
        /// </summary>
        public float GetTotalMilliseconds()
        {
            return FramesAsMilliseconds() + SecondsAsMilliseconds() + MinutesAsMilliseconds();
        }

        /// <summary>
        /// Gets complete seconds elapsed since zero.
        /// </summary>
        public float GetTotalSeconds()
        {
            return (GetTotalMilliseconds() / 1000F);
        }
    }
}
