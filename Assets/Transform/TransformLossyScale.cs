using UnityEngine;
public class TransformLossyScale : MonoBehaviour
{
    void Start()
    {
        Debug.Log("lossyScale - " + transform.lossyScale);
        Debug.Log("localScale - " + transform.localScale);
        Debug.Log("localScale.x - " + transform.localScale.x);
        Debug.Log("localScale.y - " + transform.localScale.y);
        Debug.Log("localScale.z - " + transform.localScale.z);
    }
}