using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Reloaded.Process.Functions.X86Functions;
using Reloaded.Process.Functions.X86Hooking;
using Reloaded_Mod_Template.Heroes.Definitions;

namespace Reloaded_Mod_Template.Heroes
{
    public unsafe class VictoryTracker
    {
        // Members
        private VictoryStruct* _currentVictoryCount = (VictoryStruct*) 0x009DD6BC;
        private VictoryStruct  _lastVictoryCount = new VictoryStruct();
        
        private int _playerOneTotalVictories = 0;
        private int _playerTwoTotalVictories = 0;
        private int _playerThreeTotalVictories = 0;
        private int _playerFourTotalVictories = 0;

        // Constructor
        public VictoryTracker()
        {
            _tObjTeamExecHook = FunctionHook<TObjTeam_Exec>.Create(0x005B10E0, CheckScoreIncrementHookFunction).Activate();
        }

        // Methods

        /// <summary>
        /// Player Range: 1-4 
        /// </summary>
        public int GetVictoryCount(int player)
        {
            // Update total victory numbers.
            switch (player)
            {
                case 1: return _currentVictoryCount[0].PlayerOne;
                case 2: return _currentVictoryCount[0].PlayerTwo;
                case 3: return _currentVictoryCount[0].PlayerThree;
                case 4: return _currentVictoryCount[0].PlayerFour;
                default: return 0;
            }
        }

        /// <summary>
        /// Player Range: 1-4 
        /// </summary>
        public int GetTotalVictoryCount(int player)
        {
            // Update total victory numbers.
            switch (player)
            {
                case 1: return _playerOneTotalVictories;
                case 2: return _playerTwoTotalVictories;
                case 3: return _playerThreeTotalVictories;
                case 4: return _playerFourTotalVictories;
                default: return 0;
            }
        }

        // Hooks

        [ReloadedFunction(CallingConventions.MicrosoftThiscall)]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate char TObjTeam_Exec(void* thisPointer);

        private FunctionHook<TObjTeam_Exec> _tObjTeamExecHook;

        /// <summary>
        /// Executes original function and checks for possible increment of player score.
        /// </summary>
        private char CheckScoreIncrementHookFunction(void* thispointer)
        {
            char result = _tObjTeamExecHook.OriginalFunction(thispointer);
            
            // Custom Code
            VictoryStruct currentVictories = *_currentVictoryCount;

            if (currentVictories.PlayerOne > _lastVictoryCount.PlayerOne)
                _playerOneTotalVictories++;

            if (currentVictories.PlayerTwo > _lastVictoryCount.PlayerTwo)
                _playerTwoTotalVictories++;

            if (currentVictories.PlayerThree > _lastVictoryCount.PlayerThree)
                _playerThreeTotalVictories++;

            if (currentVictories.PlayerFour > _lastVictoryCount.PlayerFour)
                _playerFourTotalVictories++;

            _lastVictoryCount = currentVictories;
            
            // End of Custom Code

            return result;
        }
    }
}
