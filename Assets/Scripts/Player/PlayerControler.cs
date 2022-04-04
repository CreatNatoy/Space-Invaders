using UnityEngine;

[RequireComponent(typeof(PlayerMover))]
[RequireComponent(typeof(PlayerShoot))]
public class PlayerControler : MonoBehaviour
{
    private PlayerMover _playerMover;
    private PlayerShoot _playerShoot;

    private void Start()
    {
        _playerMover = GetComponent<PlayerMover>();
        _playerShoot = GetComponent<PlayerShoot>(); 
    }

    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        if(moveX != 0)
        {
            _playerMover.Move(moveX); 
        }

        if (Input.GetKeyDown(KeyCode.Space))
            _playerShoot.Shoot();
    }
}
