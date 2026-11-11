using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove2D : MonoBehaviour
{
    public float moveSpeed = 3f;
    public Rigidbody2D rbody;
    public bool flip = false;
    private bool canMove = true;
    private float freezeTimer = 0f;
    private bool isFrozen = false;

    void Update()
    {
        // Stops movement when attacking
        if (Keyboard.current.spaceKey.wasPressedThisFrame && canMove && !isFrozen)
        {
            Debug.Log("STOP");
            rbody.linearVelocity = Vector2.zero;
            canMove = false;
            freezeTimer = 0.25f;
            isFrozen = true;
        }

        // Counts down the timer until the player can move again. Returns if the timer is still going
        if (isFrozen)
        {
            freezeTimer -= Time.deltaTime;
            rbody.linearVelocity = Vector2.zero;

            if (freezeTimer <= 0f)
            {
                canMove = true;
                isFrozen = false;
                Debug.Log("Recovered");
            }
            return;
        }

        // Calculate direction using player input (WASD)
        Vector2 direction = Vector2.zero;

        if (Keyboard.current.wKey.isPressed)
        {
            direction += new Vector2(0, 1);
        }
        if (Keyboard.current.sKey.isPressed)
        {
            direction += new Vector2(0, -1);
        }
        if (Keyboard.current.aKey.isPressed)
        {
            direction += new Vector2(-1, 0);
        }
        if (Keyboard.current.dKey.isPressed)
        {
            direction += new Vector2(1, 0);
        }

        // Makes sure diagonal movement isn't faster
        direction = direction.normalized;

        // Moves the Rigidbody2D
        Move(direction, moveSpeed);

        // Flips the player when moving the opposite direction (Is currently buggy when pressing A and D at the same time, will fix later)
        if (Keyboard.current.aKey.isPressed)
        {
            if (flip == false)
            {
                flip = true;
                transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
            }
        }

        if (Keyboard.current.dKey.isPressed)
        {
            if (flip == true)
            {
                flip = false;
                transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
            }
        }
    }

    private void Move(Vector2 direction, float speed)
    {
        // Adds speed to the calculated direction
        Vector2 velocity = direction * speed;
        rbody.linearVelocity = velocity;
    }
}