using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    protected void Intialize(Bullet prefab, int size, ref List<Bullet> _pool)
    {
        for (int i = 0; i < size; i++)
        {
            Bullet spawned = Instantiate(prefab, transform);
            spawned.gameObject.SetActive(false);
            _pool.Add(spawned);
        }
    }

    protected bool TryGetObject(List<Bullet> _pool, out Bullet result)
    {
        result = _pool.FirstOrDefault(p => p.gameObject.activeSelf == false);
        return result != null;
    }
}
