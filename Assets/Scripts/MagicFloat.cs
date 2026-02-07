using UnityEngine;

public class MagicFloat : MonoBehaviour
{
    public float floatSpeed = 2f;
    public float floatHeight = 0.15f;
    public float rotationSpeed = 25f;

    private Vector3 startPos;

    void Start()
    {
        // World position
        startPos = transform.position;
    }

    void Update()
    {
        // Global Y floating
        float y = Mathf.Sin(Time.time * floatSpeed) * floatHeight;
        transform.position = startPos + Vector3.up * y;

        // Global (world) rotation around Y axis
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.World);
    }
}
