using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private Spawner _spawnerBullet;

    public void Shoot()
    {
        _spawnerBullet.SetBullet();
    }
}
