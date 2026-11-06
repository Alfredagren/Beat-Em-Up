using UnityEngine;
using UnityEngine.SceneManagement;

public class Hitbox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            // Destroys the enemy parent (Need to fix enemies being able to destroy each other)
            GameObject enemyRoot = other.transform.root.gameObject;
            Destroy(enemyRoot);
        }
        else if (other.CompareTag("Player"))
        {
            // Restarts the scene on player getting hit
            Debug.Log("YOU ARE DEAD!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
