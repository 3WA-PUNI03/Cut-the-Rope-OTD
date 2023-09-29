using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.attachedRigidbody == null) return;
        if (collision.attachedRigidbody.gameObject.CompareTag("Candy"))
        {
            // Lancement des pubs


            // Puis Rechargement de la scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
