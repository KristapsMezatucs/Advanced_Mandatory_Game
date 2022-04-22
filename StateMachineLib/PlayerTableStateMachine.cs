using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachineLib
{
    class StateAction
    {
        public MovementDirectionsType HeadingState { get; set; } // next state
        public MovementDirectionsType Action { get; set; } // direction the player should move

    }

    public class PlayerTableStateMachine
    {
        // internal table as StateMachine
        private StateAction[,] _stateMachine;
        private MovementDirectionsType _currentDirrectionState;

        public PlayerTableStateMachine()
        {
            _currentDirrectionState = MovementDirectionsType.NORTH;

            // initialize table
            _stateMachine = new StateAction[4, 4];
            _stateMachine[(int)MovementDirectionsType.NORTH, (int)InputType.LEFT] = new StateAction() { HeadingState = MovementDirectionsType.WEST, Action = MovementDirectionsType.WEST };
            _stateMachine[(int)MovementDirectionsType.NORTH, (int)InputType.RIGHT] = new StateAction() { HeadingState = MovementDirectionsType.EAST, Action = MovementDirectionsType.EAST };
            _stateMachine[(int)MovementDirectionsType.NORTH, (int)InputType.FORWARD] = new StateAction() { HeadingState = MovementDirectionsType.NORTH, Action = MovementDirectionsType.NORTH };
            _stateMachine[(int)MovementDirectionsType.NORTH, (int)InputType.BACKWARD] = new StateAction() { HeadingState = MovementDirectionsType.SOUTH, Action = MovementDirectionsType.SOUTH };

            _stateMachine[(int)MovementDirectionsType.EAST, (int)InputType.LEFT] = new StateAction() { HeadingState = MovementDirectionsType.WEST, Action = MovementDirectionsType.WEST };
            _stateMachine[(int)MovementDirectionsType.EAST, (int)InputType.RIGHT] = new StateAction() { HeadingState = MovementDirectionsType.EAST, Action = MovementDirectionsType.EAST };
            _stateMachine[(int)MovementDirectionsType.EAST, (int)InputType.FORWARD] = new StateAction() { HeadingState = MovementDirectionsType.NORTH, Action = MovementDirectionsType.NORTH };
            _stateMachine[(int)MovementDirectionsType.EAST, (int)InputType.BACKWARD] = new StateAction() { HeadingState = MovementDirectionsType.SOUTH, Action = MovementDirectionsType.SOUTH };

            _stateMachine[(int)MovementDirectionsType.WEST, (int)InputType.LEFT] = new StateAction() { HeadingState = MovementDirectionsType.WEST, Action = MovementDirectionsType.WEST };
            _stateMachine[(int)MovementDirectionsType.WEST, (int)InputType.RIGHT] = new StateAction() { HeadingState = MovementDirectionsType.EAST, Action = MovementDirectionsType.EAST };
            _stateMachine[(int)MovementDirectionsType.WEST, (int)InputType.FORWARD] = new StateAction() { HeadingState = MovementDirectionsType.NORTH, Action = MovementDirectionsType.NORTH };
            _stateMachine[(int)MovementDirectionsType.WEST, (int)InputType.BACKWARD] = new StateAction() { HeadingState = MovementDirectionsType.SOUTH, Action = MovementDirectionsType.SOUTH };

            _stateMachine[(int)MovementDirectionsType.SOUTH, (int)InputType.LEFT] = new StateAction() { HeadingState = MovementDirectionsType.WEST, Action = MovementDirectionsType.WEST };
            _stateMachine[(int)MovementDirectionsType.SOUTH, (int)InputType.RIGHT] = new StateAction() { HeadingState = MovementDirectionsType.EAST, Action = MovementDirectionsType.EAST };
            _stateMachine[(int)MovementDirectionsType.SOUTH, (int)InputType.FORWARD] = new StateAction() { HeadingState = MovementDirectionsType.NORTH, Action = MovementDirectionsType.NORTH };
            _stateMachine[(int)MovementDirectionsType.SOUTH, (int)InputType.BACKWARD] = new StateAction() { HeadingState = MovementDirectionsType.SOUTH, Action = MovementDirectionsType.SOUTH };
        }

        public Move NextMove(InputType input)
        {
            // Find next move from current state and input
            MovementDirectionsType nextMove = _stateMachine[(int)_currentDirrectionState, (int)input].Action;

            // Find next state from current state and input
            _currentDirrectionState = _stateMachine[(int)_currentDirrectionState, (int)input].HeadingState;
            return ConvertDirection2Move(nextMove);
        }

        private Move ConvertDirection2Move(MovementDirectionsType nextMove)
        {
            switch (nextMove)
            {
                case MovementDirectionsType.NORTH: return MoveObjects.GoNorth;
                case MovementDirectionsType.EAST: return MoveObjects.GoEast;
                case MovementDirectionsType.SOUTH: return MoveObjects.GoSouth;

                default: return MoveObjects.GoWest;
            }
        }
    }
}
