using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachineLib
{
    public class PlayerStateMachinePattern : IState
    {
        // internal StateMachine as pattern i.e. objects
        private IStateMachinePattern _currentState;


        public PlayerStateMachinePattern()
        {

        }
        public Move NextMove(InputType input)
        {
            throw new NotImplementedException();
        }
    }
}
