using System.Collections.Generic;
using UnityEngine;

public class Spawner : ObjectPool
{
    [SerializeField] private Bullet _bulletPrefab;
    [SerializeField] private int _capacityBullet;
    [SerializeField] private Transform _spawnPointBullet;
    [SerializeField] private Bullet _missilePrefab;
    [SerializeField] private int _capacityMissile;

    private List<Bullet> _poolBullet = new List<Bullet>();
    private List<Bullet> _poolMissile = new List<Bullet>();

    private void Start()
    {
        Intialize(_bulletPrefab, _capacityBullet, ref _poolBullet);
        Intialize(_missilePrefab, _capacityMissile, ref _poolMissile);
    }

    public void SetBullet()
    {
        if (TryGetObject(_poolBullet, out Bullet bullet))
        {
            bullet.gameObject.SetActive(true);
            bullet.transform.position = _spawnPointBullet.position;
        }
    }

    public void SetMissile(Invader invader)
    {
        if (TryGetObject(_poolMissile, out Bullet Missile))
        {
            Missile.gameObject.SetActive(true);
            Missile.transform.position = invader.GetPosition();
            Missile.BulletMove.SetSpeed(invader.SpeedShoot);
            Missile.BulletDamage.SetDamage(invader.Damage);
        }
    }
}