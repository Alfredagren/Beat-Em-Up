using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    public static int enemiesLeft;
    [SerializeField] private TMP_Text enemyCountText;

    void Update()
    {
        // Counts how many enemies are left and adds it to the assigned text object
        enemiesLeft = GameObject.FindGameObjectsWithTag("Enemy").Length;
        enemyCountText.text = "Enemies Left: " + enemiesLeft;
    } 
}