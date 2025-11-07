using UnityEngine;

public class ChangeColorOnCollision : MonoBehaviour
{
    private Renderer rend;
    public Color hitColor = Color.red;
    private Color originalColor;

    void Start()
    {

        rend = GetComponent<Renderer>();
        if (rend != null)
        {
            originalColor = rend.material.color;
        }
    }

    void OnCollisionEnter(Collision collision)
    {

        if (rend != null)
        {
            rend.material.color = hitColor;
        }

        Debug.Log($"{gameObject.name} botste met {collision.gameObject.name}");
    }

    void OnCollisionExit(Collision collision)
    {

        if (rend != null)
        {
            rend.material.color = originalColor;
        }
    }
}
