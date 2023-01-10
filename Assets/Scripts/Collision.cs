using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    private MeshRenderer obstacleMesh;
    private bool isDestroyed = false;
  

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {

        
        if (collision.gameObject.CompareTag("Player"))
        {
            obstacleMesh = GetComponent<MeshRenderer>();
            obstacleMesh.material.color = Color.red;
            Destroy(collision.gameObject);
            Debug.Log("You Lost");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}
