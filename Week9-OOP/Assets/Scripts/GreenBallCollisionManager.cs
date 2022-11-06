using System;
using UnityEngine;

public class GreenBallCollisionManager : BallCollisionManager
{
    public override void CollideWithBall(GameObject OtherBall)
    {
        Debug.Log("Green Ball Collision Manager Function");
        if (OtherBall.GetComponent<YellowBallCollisionManager>() != null)
        {
            Debug.Log("Blue Collided With Yellow");
            
            Destroy(OtherBall);

        }
       
    }
}

