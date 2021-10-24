using UnityEngine;
public class Vector3OrthoNormalize : MonoBehaviour
{
    public Transform normal;
    public Vector3 vector1;
    public Vector3 vector2;
    public Vector3 vector3;
    void Update()
    {
        // vector1 = normal.position;
        // Vector3.OrthoNormalize(ref vector1, ref vector2);
        // Debug.DrawRay(Vector3.zero, vector1*10, Color.blue);
        // Debug.DrawRay(Vector3.zero, vector2*10, Color.red);

        vector1 = normal.position;
        Vector3.OrthoNormalize(ref vector1, ref vector2, ref vector3);
        Debug.DrawRay(Vector3.zero, vector1*10, Color.blue);
        Debug.DrawRay(Vector3.zero, vector2*10, Color.red);
        Debug.DrawRay(Vector3.zero, vector3*10, Color.green);
    }
}