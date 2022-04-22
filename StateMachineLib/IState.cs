using System;

namespace StateMachineLib
{
    public enum MovementDirectionsType
    {
        NORTH,
        WEST,
        SOUTH,
        EAST
    };

    public enum InputType
    {
        LEFT,
        RIGHT,
        FORWARD,
        BACKWARD
    };

    public record Move(int row, int col);

    public interface IState
    {
        Move NextMove(InputType input);
    }
}
