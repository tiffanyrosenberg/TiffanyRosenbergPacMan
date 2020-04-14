using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : MonoBehaviour
{
    [SerializeField] int maxHits =3;
    [SerializeField] int currentHits = 0;

    private void OnCollisionEnter2D(Collision2D coll)
    {
        currentHits += 1;
        checkHit();
    }

    void checkHit()
    {
        if (currentHits == maxHits)
        {
            Destroy(gameObject);
        }
    }
}
