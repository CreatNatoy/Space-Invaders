using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class Bunker : MonoBehaviour, IDamage
{
    [SerializeField] private int _health = 3;
    [SerializeField] private Color[] _colors;

    private Renderer _renderer;
    private int _amountColor = 0;

    private void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        TakeDamage(1);
    }

    private void Die()
    {
        gameObject.SetActive(false); 
    }

    private void ChangeColor()
    {
        _renderer.material.color = _colors[_amountColor];
        _amountColor++;
    }

    public void TakeDamage(int damage)
    {
        _health--;
        if (_health <= 0)
        {
            Die();
            return;
        }
        ChangeColor();
    }
}
