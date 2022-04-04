using UnityEngine;
using UnityEngine.UI;

public class IntroState : State
{
    private StateMachine _stateMachine;
    private Text _textSpaceInvaders;
    private string _stringSpaceInvaders = "Space Invaders";
    private int _indexText = 0;
    private float _timer;
    private float _waitTime = 0.2f;

    public IntroState(StateMachine stateMachine, GameStateManager gameManager) : base(gameManager)
    {
        _stateMachine = stateMachine;
        _textSpaceInvaders = _gameManager.TextSpaceInvaders;
        _waitTime = _gameManager.WaitTimeText;
    }

    public override void Enter()
    {
        Debug.Log("Enter Intro State");
        DisableControllerPlayer();
    }

    public override void Exit()
    {
        Debug.Log("Exit Intro State");
    }


    public override void Update()
    {
        _timer += Time.deltaTime;
        if (_timer >= _waitTime)
        {
            _timer = 0f;
            EffectText();
        }
    }

    private void EffectText()
    {
        if (_indexText < _stringSpaceInvaders.Length)
        {
            _textSpaceInvaders.text += _stringSpaceInvaders[_indexText];
            _indexText++;
        }
        else
        {
            _textSpaceInvaders.enabled = false;
            _stateMachine.ChangeState(new InvadersState(_stateMachine, _gameManager));
        }
    }

    private void DisableControllerPlayer()
    {
        _gameManager.PlayerControler.enabled = false;
    }

}
