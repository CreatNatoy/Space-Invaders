using UnityEngine;

[RequireComponent(typeof(InvadersSpawn))]
public class InvadersMover : MoveBasic
{
    [SerializeField] private float _distanceDown;
    [SerializeField] private Spawner _spawnerMissile;
    private Vector3 _direction;
    private InvadersSpawn _invadersSpawn;

    protected override void Start()
    {
        base.Start();
        _direction = Vector3.right;
        _invadersSpawn = GetComponent<InvadersSpawn>();
    }

    private void Update()
    {
        if (_invadersSpawn.IsSpawnReady)
            Move();
    }

    public void Move()
    {
        transform.position += _direction * _speed * Time.deltaTime;

        foreach (var invader in _invadersSpawn.Invaders)
        {
            if (invader.gameObject.transform.position.x >= (_rightEdge.x - 1f) && _direction == Vector3.right)
            {
                ChangeDirection();
                GoDown();
            }
            else if (invader.gameObject.transform.position.x <= (_leftEdge.x + 1f) && _direction == Vector3.left)
            {
                ChangeDirection();
                GoDown();
            }
        }
    }

    private void ChangeDirection()
    {
        _direction.x = -_direction.x;
    }

    private void GoDown()
    {
        Vector3 position = transform.position;
        position.y -= _distanceDown;
        transform.position = position;
    }
}
