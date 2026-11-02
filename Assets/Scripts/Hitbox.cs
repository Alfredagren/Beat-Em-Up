using UnityEngine;

public class Hitbox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            GameObject enemyRoot = other.transform.root.gameObject;
            Destroy(enemyRoot);
        }
    }
}
