using UnityEngine;

public class Hitbox : MonoBehaviour
{
    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

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
            // Testing to see if the enemies can hit you
            Debug.Log("YOU ARE DEAD!");
            QuitGame();
        }
    }
}
