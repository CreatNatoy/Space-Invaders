using UnityEngine;
using UnityEngine.Events;

public class PlayerScore : MonoBehaviour
{
    private int _score = 0; 

    public int Score => _score;

    public event UnityAction<int> ScoreUI;

    private void Start()
    {
        ScoreUI?.Invoke(_score);
    }

    public void ApplyScore(int score)
    {
        _score += score;
        ScoreUI?.Invoke(_score); 
    }
}
