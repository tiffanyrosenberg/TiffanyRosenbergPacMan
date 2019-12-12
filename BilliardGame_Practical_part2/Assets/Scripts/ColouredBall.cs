using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColouredBall : MonoBehaviour
{
    void DestroyBallWhenItHitsHole(Collision2D col, CircleCollider2D Hole)
    {

        if(gameObject.name =="RightHole" || gameObject.name == "LeftHole")
        {
            Destroy(col.gameObject);
        }
    }
}