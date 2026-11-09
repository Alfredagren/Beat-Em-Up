using UnityEngine;
using UnityEngine.SceneManagement;

public class Hitbox : MonoBehaviour
{
    private Menus menuScript;
    private void Start()
    {
        // Reference the Menus script
        menuScript = FindFirstObjectByType<Menus>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            // Destroys the enemy parent
            GameObject enemyRoot = other.transform.root.gameObject;
            Destroy(enemyRoot);
        }
        else if (other.CompareTag("Final Boss"))
        {
            Debug.Log("You beat the boss");
            menuScript.WinGame();
        }

    }
}
