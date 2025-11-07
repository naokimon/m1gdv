using UnityEngine;

public class Physicscontroller : MonoBehaviour
{
    private Rigidbody rb;
    public float bewegingsKracht = 10.0f;
    public float springKracht = 300.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 beweging = new Vector3(horizontal, 0, vertical);
        rb.AddForce(beweging * bewegingsKracht);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * springKracht);
        }

        Debug.Log("Snelheid: " + rb.linearVelocity.magnitude);
    }
}
