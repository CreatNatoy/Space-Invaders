using UnityEngine;

[RequireComponent(typeof(BulletDamage))]
[RequireComponent(typeof(BulletMove))]
public class Bullet : MonoBehaviour
{
    private BulletMove _bulletMove;
    private BulletDamage _bulletDamage;

    public BulletMove BulletMove => _bulletMove;
    public BulletDamage BulletDamage => _bulletDamage;

    private void Awake()
    {
        _bulletDamage = GetComponent<BulletDamage>();
        _bulletMove = GetComponent<BulletMove>(); 
    }
}
