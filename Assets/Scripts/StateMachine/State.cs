public abstract class State
{
    public GameStateManager _gameManager; 

    public State(GameStateManager gameManager)
    {
        _gameManager = gameManager; 
    }

    public abstract void Enter();

    public abstract void Exit();

    public virtual void Update() 
    {
    }
}
