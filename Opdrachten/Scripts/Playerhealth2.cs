using Unity.VisualScripting;
using UnityEngine;

public class Healthbar : MonoBehaviour
{
    public int health = 100;
    public int maxHealth = 100;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            Debug.Log("H key detected");
            TakeDamage(20);
        }
    }

    public void TakeDamage(int incomingDamage)
    {
        health -= incomingDamage;
        Debug.Log("Took " + incomingDamage + " damage! Health: " + health);

        if (health <= 0)
        {
            Die();
        }
        else if (health < 20)
        {
            Debug.Log("WARNING: Low health!");
        }
    }

    void Die()
    {
        Debug.Log("Player died!");
        Destroy(gameObject);
    }
}
