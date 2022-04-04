using UnityEngine;

public class GameState : State
{

    public GameState(GameStateManager gameManager):base(gameManager)
    {
    }

    public override void Enter()
    {
        Debug.Log("Enter GameState State");
        ActivateControllerPlayer();
    }

    public override void Exit()
    {
        Debug.Log("Exit GameState State");
    }

    private void ActivateControllerPlayer()
    {
        _gameManager.PlayerControler.enabled = true; 
    }
}
