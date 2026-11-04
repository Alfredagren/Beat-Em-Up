using System.ComponentModel.Design.Serialization;
using UnityEngine;

public class EnemyBatSwing : MonoBehaviour
{
    Animator animator;
    Transform player;
    public float attackRange = 1.5f;

    void Start()
    {
        // Locates the animator and player position
        animator = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        // Attacks when close to the player
        if (Vector2.Distance(transform.position, player.position) <= attackRange)
        {
            Debug.Log("Watch out!");
            animator.SetTrigger("Swing");            
        }
    }
}