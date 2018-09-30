using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded_Mod_Template.Native
{
    public class PSAPI
    {
        /*
            ----------------------
            Additional DLL Imports 
            ----------------------
        */

        [DllImport("psapi", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool QueryWorkingSetEx(IntPtr hProcess, [In, Out] PSAPI_WORKING_SET_EX_INFORMATION[] pv, int cb);

        [StructLayout(LayoutKind.Sequential)]
        public struct PSAPI_WORKING_SET_EX_INFORMATION
        {
            public IntPtr VirtualAddress;
            public PSAPI_WORKING_SET_EX_BLOCK VirtualAttributes;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct PSAPI_WORKING_SET_EX_BLOCK
        {
            public ulong Flags;
            public ulong Invalid;
        }
    }
}
