using UnityEngine;

public class Hitbox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            // Destroys the enemy parent
            GameObject enemyRoot = other.transform.root.gameObject;
            Destroy(enemyRoot);
        }
    }
}
