using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

/*
[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay())}(),nq}}")]
public class CollisionColorChange : MonoBehaviour
{

    public Color orangecolor;
    //public Color bluecolor;

    
    public override void CollideWithBall(GameObject OtherBall)
    {

        if (other.gameObject.CompareTag("Ball"))
        {
            Debug.Log("Red Collided with Yellow");
            transform.GetComponent<Renderer>().material.color = orangecolor;
        }
    }

    public void Global { get => global; set => this.global = value; }
}
*/

    /*
    public class RedBallCollisionManager : BallCollisionManager
    {
            public color orangecolor;

        public override void CollideWithBall(GameObject OtherBall)
        {
            Debug.Log("Red Ball Collision Manager Function");

            if (OtherBall.GetComponent<YellowBallCollisionManager>() != null)
            {
                Debug.Log("Red Collided With Yellow");
                    transform.GetComponent<Render>().material.color = orangecolor;
            }
        }
    }
    */

    /*
    public class Colour : MonoBehavior
    {
        void OncollisionEnter(Collision col)
        {
            if(col.gameObject.tag == "Ball")
            {
                object p = col.gameObject.GetComponent<Renderer>(); material.color = Color.orange;
            }
        }
    }
    */