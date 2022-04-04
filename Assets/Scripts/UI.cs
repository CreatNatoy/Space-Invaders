using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] private PlayerHealth _playerHealth;
    [SerializeField] private Text _textHealth;
    [SerializeField] private PlayerScore _playerScore;
    [SerializeField] private Text _textScore;

    private void OnEnable()
    {
        _playerHealth.HealthUI += OnHealthPlayer;
        _playerScore.ScoreUI += OnScore;
    }

    private void OnDisable()
    {
        _playerHealth.HealthUI -= OnHealthPlayer;
        _playerScore.ScoreUI -= OnScore;
    }

    private void OnHealthPlayer(int health)
    {
        _textHealth.text = health.ToString(); 
    }

    private void OnScore(int score)
    {
        _textScore.text = score.ToString(); 
    }
}
