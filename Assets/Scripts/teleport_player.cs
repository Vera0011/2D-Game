using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teleport_player : MonoBehaviour
{
    public Collider2D[] playerCollider;
    public int[] sceneManager;

    void OnTriggerEnter2D(Collider2D collider)
    {
        for (int i = 0; i < playerCollider.Length; i++)
        {
            if (collider.Equals(playerCollider[i]))
            {
                SceneManager.LoadScene(sceneManager[i]);
            }
        }
    }
}
