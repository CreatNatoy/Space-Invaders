using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    private int _damage = 1;
    public int Damage => _damage; 

    public void SetDamage(int damage)
    {
        _damage = damage; 
    }
}
