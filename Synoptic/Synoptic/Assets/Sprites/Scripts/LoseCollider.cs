using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour
{
    private void OnCollisionEnter2D(Collider2D ball)
    {
        SceneManager.LoadScene("End");
    }
}
