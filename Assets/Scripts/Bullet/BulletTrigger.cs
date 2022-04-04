using UnityEngine;

public class BulletTrigger : MonoBehaviour
{
    [SerializeField] private BulletDamage _bulletDamage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Invader invader = collision.GetComponent<Invader>();
        if (invader)
        {
            InvadersSpawn _listInvader = invader.GetComponentInParent<InvadersSpawn>();
            _listInvader.DeleteInvader(invader);
        }

        IDamage damage = collision.GetComponent<IDamage>();
        if (damage != null)
        {
            damage.TakeDamage(_bulletDamage.Damage);
        }

        gameObject.SetActive(false);
    }
}
