using UnityEngine;

public class Invader : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private float _speedShoot;
    [SerializeField] private int _score;

    private Transform _invaderTransform; 

    public int Damage => _damage;
    public float SpeedShoot => _speedShoot;
    public int Score => _score;

    private void Awake()
    {
        _invaderTransform = transform; 
    }

    public void Set—haracteristic(int damage, float speedShoot, int score)
    {
        _damage = damage;
        _speedShoot = speedShoot;
        _score = score;
    }

    public Vector3 GetPosition()
    {
        return _invaderTransform.position; 
    }
}
