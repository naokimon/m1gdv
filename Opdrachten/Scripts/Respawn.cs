using UnityEngine;

public class RespawnTrigger : MonoBehaviour
{
    private Vector3 respawnPoint = new Vector3(-20.92f, 3.24f, 20.43f);

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = respawnPoint;

            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.linearVelocity = Vector3.zero;
            }
        }
    }
}
