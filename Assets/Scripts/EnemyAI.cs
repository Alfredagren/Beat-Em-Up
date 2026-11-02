using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float moveSpeed;
    private Transform player;

    void Start()
    {
        // References the player position
        player = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        // Moves towards the player
        transform.position = Vector2.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
    }
}