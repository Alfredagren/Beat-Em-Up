using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class EnemyAI : MonoBehaviour
{
    public float moveSpeed;
    private Transform player;
    public bool flip = false;
    public Rigidbody2D rbody;

    void Start()
    {
        // References the player position
        player = GameObject.FindWithTag("Player").transform;
    }


    void Update()
    {
        // Moves the rigidbody towards the player
        Vector2 newPos = Vector2.MoveTowards(rbody.position, player.position, moveSpeed * Time.fixedDeltaTime);
        rbody.MovePosition(newPos);

        // Flips the enemy if the player passes its X-value
        if (transform.position.x > player.position.x)
        {
            if (flip == false)
            {
                flip = true;
                transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
            }
        }
        // Flips the enemy back if the player has less in X-value
        else
        {
            if (flip == true)
            {
                flip = false;
                transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
            }
        }
    }
}