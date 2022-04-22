using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachineLib
{
    public class StateMachinePatternWest : IStateMachinePattern
    {
        private static readonly IStateMachinePattern NORTH = StateObjects.North;
        private static readonly IStateMachinePattern EAST = StateObjects.East;
        private static readonly IStateMachinePattern SOUTH = StateObjects.South;


        public IStateMachinePattern NextState(InputType input)
        {
            switch (input)
            {
                case InputType.FORWARD: return NORTH;
                case InputType.LEFT: return this;
                case InputType.RIGHT: return EAST;
                case InputType.BACKWARD: return SOUTH;
            }

            return this;
        }

        public Move NextAction(InputType input)
        {
            switch (input)
            {
                case InputType.FORWARD: return MoveObjects.GoNorth;
                case InputType.LEFT: return MoveObjects.GoWest;
                case InputType.RIGHT: return MoveObjects.GoEast;
                case InputType.BACKWARD: return MoveObjects.GoSouth;
            }

            return MoveObjects.GoWest;
        }
    }
}
