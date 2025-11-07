using UnityEngine;

public class Ballshooter : MonoBehaviour
{
    [SerializeField] private Vector3 initialVelocity = new Vector3(8f, 0f, 0f);
    private Rigidbody rb;
    void Awake() { rb = GetComponent<Rigidbody>(); }
    void Start() { rb.linearVelocity = initialVelocity; }
}
