using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachineLib
{
    public interface IStateMachinePattern
    {
        IStateMachinePattern NextState(InputType input);
        Move NextAction(InputType input);
    }
}
