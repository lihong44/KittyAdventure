namespace KittyAdventure;

public class State : BaseState
{
    public StateType Type;
    public State(StateType stateType) : base()
    {
        Type = stateType;
    }
}