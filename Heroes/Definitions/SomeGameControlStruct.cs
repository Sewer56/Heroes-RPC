using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Reloaded_Mod_Template.Heroes.Definitions.Enums;

namespace Reloaded_Mod_Template.Heroes.Definitions
{
    [StructLayout(LayoutKind.Explicit)]
    public struct SomeGameControlStruct
    {
        [FieldOffset(0x00000027)]
        public byte StoryModeFlag;

        [FieldOffset(0x00000028)]
        public MissionMode MissionMode;
    }
}
