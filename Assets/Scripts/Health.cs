using UnityEngine;

public class Health : MonoBehaviour
{
    public float healthPoints = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (CompareTag("Player"))
        {
            healthPoints = 3;
        }
        else if (CompareTag("Enemy"))
        {
            healthPoints = 1;

        }
    }

        // Update is called once per frame
    void Update()
    {
        if (healthPoints == 0)
        {
            Debug.Log("DEAD");
        }
    }
}
