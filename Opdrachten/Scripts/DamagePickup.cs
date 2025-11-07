using UnityEngine;

public class DamagePickup : MonoBehaviour
{
    public int damageAmount = 20;
    public bool destroyOnHit = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();

            if (playerHealth != null)
            {
                playerHealth.currentHealth -= damageAmount;

                if (playerHealth.currentHealth < 0)
                    playerHealth.currentHealth = 0;

                Debug.Log("Speler kreeg " + damageAmount + " schade! Health: " + playerHealth.currentHealth);
            }
        }
    }
}

