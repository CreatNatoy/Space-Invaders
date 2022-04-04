using UnityEngine;

public class BulletMove : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private bool _DirectionUp;
    private Vector3 _direction; 

    private void Start()
    {
        ChoiceDirection();
    }

    private void Update()
    {
        transform.position += _direction * _speed * Time.deltaTime;
    }

    private void ChoiceDirection()
    {
        if (_DirectionUp)
            _direction = Vector3.up;
        else
            _direction = Vector3.down;
    }

    public void SetSpeed(float speed)
    {
        _speed = speed; 
    }
}
