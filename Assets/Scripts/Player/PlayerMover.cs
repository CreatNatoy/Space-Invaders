using UnityEngine;

public class PlayerMover : MoveBasic
{

    public void Move(float direction)
    {
        if(CheckLimitationMonovement(direction))
        transform.position += new Vector3(direction * _speed * Time.deltaTime, 0, 0);
    }

    private bool CheckLimitationMonovement(float direction)
    {
        if ((transform.position.x <= (_rightEdge.x - 1f) || direction < 0)
            && (transform.position.x >= (_leftEdge.x + 1f) || direction > 0))
            return true;
        else
            return false; 
    }
}
