using UnityEngine;
using UnityEngine.UI;

public class FinishState : State
{
    private Text _textFinish; 


    public FinishState(GameStateManager gameManager):base(gameManager)
    {
        _textFinish = _gameManager.TextSpaceInvaders; 
    }

    public override void Enter()
    {
        Debug.Log("Enter Finish State");
        DisableInvaders();
        SetTextFinish();
    }

    public override void Exit()
    {
        Debug.Log("Enter Exit State");
    }

    private void SetTextFinish()
    {
        _textFinish.enabled = true;
        _textFinish.text = "YOU WIN";
    }

    private void DisableInvaders()
    {
        _gameManager.InvadersSpawn.gameObject.SetActive(false); 
    }
}
