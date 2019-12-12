using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class WhiteBall : MonoBehaviour
{ 
    Vector3 White;
    Rigidbody m_Rigidbody;

    private class DestroyBallWhenItHitsHole(Collision2D col, CircleCollider2D Hole) = private new DestroyBallWhenItHitsHole(Collision2D col, CircleCollider2D Hole)


    // Start is called before the first frame update
    void Start()
    {
        GetX();
        GetY();
        White = new Vector3(x, y);
        m_Rigidbody = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {
        m_Rigidbody.velocity = White;

    }

    float GetX(float x)
    {

        x = Random.Range(-1, 1);
        

        return x;
    }

    int GetY(int y)
    {
       
        y = Random.Range(15, 20);

       
        return y;

    }
}
