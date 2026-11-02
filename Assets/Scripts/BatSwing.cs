using UnityEngine;
using UnityEngine.InputSystem;

public class BatSwing : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Swings the bat upon pressing spacebar
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Debug.Log("Lucille Give Me Strength!");
            animator.SetTrigger("Swing");
        }
    }
}