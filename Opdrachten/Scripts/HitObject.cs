using UnityEngine;

public class HitObject : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Ik botste tegen " + collision.gameObject.name);
    }

}
