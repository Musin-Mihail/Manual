using UnityEngine;
public class TransformPosition : MonoBehaviour
{
    void Start()
    {
        Debug.Log("position - " + transform.position);
        Debug.Log("localPosition - " + transform.localPosition);
    }
}