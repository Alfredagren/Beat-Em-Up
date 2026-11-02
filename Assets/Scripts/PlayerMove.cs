using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove2D : MonoBehaviour
{
    public float moveSpeed = 3f;
    public Rigidbody2D rbody;
    public bool flip = false;

    private void Update()
    {
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

        // Move the Rigidbody2D
        Move(direction, moveSpeed);

        // Flips the player when moving the opposite direction (Is currently buggy when pressing A and D at the same time, will fix later)
        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            if (flip == false)
            {
                flip = true;
                transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
            }
        }

        if (Keyboard.current.dKey.wasPressedThisFrame)
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