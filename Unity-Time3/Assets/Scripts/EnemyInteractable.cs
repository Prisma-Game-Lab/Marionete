using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyInteractable : MonoBehaviour
{
     public void OnTriggerEnter2D(Collider2D other)
     {
            if (other.gameObject.tag == "Player")
            {
                SceneManager.LoadScene("Fight");
            }
     }
}
