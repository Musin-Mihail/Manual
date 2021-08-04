using UnityEngine;

public class TransformRotateAround : MonoBehaviour
{
    public GameObject center;
    public Vector3 axis;
    void Update()
    {
        transform.RotateAround(center.transform.position, axis, 0.5f);
    }
}