using UnityEngine;

public class CoinCollecting : MonoBehaviour
{
    private static int score = 0; 

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            score += 10;
            Debug.Log("Score: " + score);
        }
    }
}

