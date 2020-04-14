using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    [SerializeField] int maxHits = 2;
    [SerializeField] int currentHits = 0;

    private void OnCollisionEnter2D(Collision2D coll)
    {
        currentHits += 1;
        checkHit();
    }

    void checkHit()
    {
        if (currentHits == 2)
        {
            Destroy(gameObject);
        }
    }
}
