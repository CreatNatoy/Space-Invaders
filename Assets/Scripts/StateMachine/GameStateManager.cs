using UnityEngine;
using UnityEngine.UI;

public class GameStateManager : MonoBehaviour
{
    [SerializeField] private Text _textSpaceInvaders;
    [SerializeField] private float _waitTimeText = 0.2f;
    [SerializeField] private InvadersSpawn _invadersSpawn;
    [SerializeField] private PlayerControler _playerControler;

    private StateMachine _stateMachine;
    private GameStateManager _gameManager; 

    public Text TextSpaceInvaders => _textSpaceInvaders; 
    public float WaitTimeText => _waitTimeText; 
    public InvadersSpawn InvadersSpawn => _invadersSpawn;
    public PlayerControler PlayerControler => _playerControler;

    private void Start()
    {
        _gameManager = this; 
        _stateMachine = new StateMachine();
        _stateMachine.Initialize(new IntroState(_stateMachine, _gameManager));
    }

    private void Update()
    {
        _stateMachine.CurrentState.Update();
    }

    public void FinishState()
    {
        _stateMachine.ChangeState(new FinishState(_gameManager));
    }

    public void GameOverState()
    {
        _stateMachine.ChangeState(new GameOverState(_gameManager));
    }
}
