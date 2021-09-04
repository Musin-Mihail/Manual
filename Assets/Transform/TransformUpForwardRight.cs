using UnityEngine;
public class TransformUpForwardRight : MonoBehaviour
{
    void Update()
    {
        // transform.position += transform.up * 0.01f;
        // transform.position += -transform.forward * 0.01f;
        transform.position -= transform.right * 0.01f;
    }
}