using UnityEngine;
public class Vector3ProjectOnPlane : MonoBehaviour
{
    public Transform vector;
    public Transform normal;
    public Transform result;
    void Update()
    {
        result.position = Vector3.ProjectOnPlane(vector.position, normal.forward);
        Debug.DrawRay(normal.position, result.position*10, Color.green);
        Debug.DrawRay(vector.position, result.position-vector.position, Color.blue);
    }
}
