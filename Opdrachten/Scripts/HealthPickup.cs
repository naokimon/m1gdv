using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public int healAmount = 20; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            PlayerHealth playerHealth = other.GetComponent <PlayerHealth>();

            if (playerHealth != null)
            {
                
                if (playerHealth.currentHealth < playerHealth.maxHealth)
                {
                    
                    playerHealth.currentHealth += healAmount;

                    
                    if (playerHealth.currentHealth > playerHealth.maxHealth)
                        playerHealth.currentHealth = playerHealth.maxHealth;

                    Debug.Log("Health pickup gebruikt! Nieuwe health: " + playerHealth.currentHealth);

                }
                else
                {
                    Debug.Log("Health is al vol!");
                }
            }
        }
    }
}
