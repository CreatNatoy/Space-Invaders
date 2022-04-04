using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour, IDamage
{
    [SerializeField] private GameStateManager _gameState; 
    [SerializeField] private int _health = 100;

    public event UnityAction<int> HealthUI;

    private void Start()
    {
        HealthUI?.Invoke(_health); 
    }

    public void TakeDamage(int damage)
    {
        _health = Mathf.Max(_health - damage, 0);
        HealthUI?.Invoke(_health); 
        if(_health == 0 )
        {
            Die();
        }
    }

    private void Die()
    {
        _gameState.GameOverState(); 
    }
}
