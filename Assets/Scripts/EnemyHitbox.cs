using UnityEngine;

public class EnemyHitbox : MonoBehaviour
{
    private Menus menuScript;

    private void Start()
    {
        // Reference the Menus script
        menuScript = FindFirstObjectByType<Menus>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Runs the LoseGame function from the Menus script
            Debug.Log("YOU ARE DEAD!");
            menuScript.LoseGame();
        }
    }
}