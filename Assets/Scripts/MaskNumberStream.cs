using UnityEngine;
using TMPro;

public class MaskNumberStream : MonoBehaviour
{
    public float speed = 0.4f;
    public float spacing = 0.6f;
    public int maxCharacters = 20;

    private TextMeshPro tmp;
    private float offset;

    void Start()
    {
        tmp = GetComponent<TextMeshPro>();
        tmp.text = "";
    }

    void Update()
    {
        // Move text forward
        offset += speed * Time.deltaTime;
        transform.localPosition = Vector3.forward * offset;

        // Add numbers over time
        if (tmp.text.Length < maxCharacters)
        {
            tmp.text += Random.Range(0, 2); // 0 or 1
        }

        // Reset when too far
        if (offset > spacing)
        {
            offset = 0f;
            tmp.text = "";
        }
    }
}
