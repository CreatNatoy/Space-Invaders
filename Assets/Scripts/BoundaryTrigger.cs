using UnityEngine;

public class BoundaryTrigger : MonoBehaviour
{
    [SerializeField] private GameStateManager _gameManager; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Invader invader = collision.GetComponent<Invader>(); 
        if(invader)
        {
            _gameManager.GameOverState(); 
        }
    }
}
