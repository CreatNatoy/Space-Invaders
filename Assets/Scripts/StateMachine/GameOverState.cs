using UnityEngine;
using UnityEngine.UI;

public class GameOverState : State
{
    private Text _textGameOver;
    private PlayerControler _playerControler;
    private InvadersSpawn _invadersSpawn;


    public GameOverState(GameStateManager gameManager) : base(gameManager)
    {
        _textGameOver = _gameManager.TextSpaceInvaders;
        _playerControler = _gameManager.PlayerControler;
        _invadersSpawn = _gameManager.InvadersSpawn; 
    }

    public override void Enter()
    {
        Debug.Log("Enter GameOver State");
        SetText();
        DisablePlayerAndInvaders(); 
    }

    public override void Exit()
    {
        Debug.Log("Exit GameOver State");
    }

    private void DisablePlayerAndInvaders()
    {
        _invadersSpawn.gameObject.SetActive(false);
        _playerControler.gameObject.SetActive(false);
    }

    private void SetText()
    {
        _textGameOver.enabled = true;
        _textGameOver.text = "Game over";
    }
}
