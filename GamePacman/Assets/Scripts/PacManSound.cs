using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacManSound : MonoBehaviour
{
    function OnTriggerEnter(hit : Collider)
    {
        if (hit.name == "PacMan" || hit.gameObject.tag == "PacMan")
            audio.Play();
    }

}
