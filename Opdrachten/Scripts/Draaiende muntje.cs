using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class Draaiendemuntje : MonoBehaviour
{
    public float rotateSpeed = 5;


    void Start()
    {

    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        transform.Rotate(rotateSpeed, 0, 0);
    }
}
