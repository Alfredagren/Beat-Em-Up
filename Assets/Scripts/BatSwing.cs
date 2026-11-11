using UnityEngine;
using UnityEngine.InputSystem;

public class BatSwing : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        // Gives the object access to the animator
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Activates the Bat_WindUp and Bat_Swing activation upon pressing spacebar
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Debug.Log("Lucille Give Me Strength!");
            animator.SetTrigger("Swing");
        }
    }
}