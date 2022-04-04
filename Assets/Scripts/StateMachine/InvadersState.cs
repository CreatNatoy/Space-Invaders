using UnityEngine;

public class InvadersState : State
{
    private StateMachine _stateMachine;
    private InvadersSpawn _invadersSpawn;

    public InvadersState(StateMachine stateMachine, GameStateManager gameManager) : base(gameManager)
    {
        _stateMachine = stateMachine; 
        _invadersSpawn = _gameManager.InvadersSpawn;
    }

    public override void Enter()
    {
        Debug.Log("Enter Invaders State");
        _invadersSpawn.Spawn();
        _stateMachine.ChangeState(new GameState(_gameManager)); 
    }

    public override void Exit()
    {
        Debug.Log("Enter Invaders State");
    }
}
