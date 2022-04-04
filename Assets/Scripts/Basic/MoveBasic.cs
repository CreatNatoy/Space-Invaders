using UnityEngine;

public abstract class MoveBasic : MonoBehaviour
{
   [SerializeField] protected float _speed;
    protected Vector3 _leftEdge;
    protected Vector3 _rightEdge;

    protected virtual void Start()
    {
        _leftEdge = Camera.main.ViewportToWorldPoint(Vector3.zero);
        _rightEdge = Camera.main.ViewportToWorldPoint(Vector3.right);
    }
}
