using UnityEngine;
public class TransformRotation : MonoBehaviour
{
    void Start()
    {
        Debug.Log("rotation - " + transform.rotation);
        Debug.Log("localRotation - " + transform.localRotation);
        Debug.Log("localRotation - " + transform.localRotation.x);
        Debug.Log("localRotation - " + transform.localRotation.y);
        Debug.Log("localRotation - " + transform.localRotation.z);
        Debug.Log("localRotation - " + transform.localRotation.w);
    }
}