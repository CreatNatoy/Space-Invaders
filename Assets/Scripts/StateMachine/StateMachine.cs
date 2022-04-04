public class StateMachine
{
    private State _currentState;

    public State CurrentState => _currentState;

    public void Initialize(State startState)
    {
        _currentState = startState;
        _currentState.Enter(); 
    }

    public void ChangeState(State newState)
    {
        _currentState.Exit();
        _currentState = newState;
        _currentState.Enter(); 
    }
}
