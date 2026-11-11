using UnityEngine;

public class HitboxEnableDisable : MonoBehaviour
{
    // Reference the gameobject with the name "Hitbox"
    public string hitboxName = "Hitbox";
    private GameObject hitbox;

    void Awake()
    {
        // Locates the hitbox child object attached to the weapon and deactivates it
        Transform child = transform.Find(hitboxName);
        hitbox = child.gameObject;
        hitbox.SetActive(false);
    }

    public void EnableHitbox()
    {
        // Turns on the hitbox object
        Debug.Log("Hitbox turned on");
        hitbox.SetActive(true);
    }

    public void DisableHitbox()
    {
        // Turns off the hitbox object
        Debug.Log("Hitbox turned off");
        hitbox.SetActive(false);
    }
}