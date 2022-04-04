using UnityEngine;

[RequireComponent(typeof(InvadersSpawn))]
public class InvadersShoot : MonoBehaviour
{
    [SerializeField] private Spawner _spawnerMissile;
    [SerializeField] private float _timeBetweenShoot = 1.5f;
    private float _timer = 0f;
    private InvadersSpawn _invadersSpawn;

    private void Start()
    {
        _invadersSpawn = GetComponent<InvadersSpawn>();
    }

    private void Update()
    {
        if (_invadersSpawn.IsSpawnReady)
        {
            _timer += Time.deltaTime;
            if (_timer >= _timeBetweenShoot)
            {
                Shoot();
                _timer = 0f;
            }
        }
    }

    private void Shoot()
    {
        int index = Random.Range(0, _invadersSpawn.Invaders.Count);
        Invader invaderShoot = _invadersSpawn.Invaders[index];
        _spawnerMissile.SetMissile(invaderShoot);
    }
}