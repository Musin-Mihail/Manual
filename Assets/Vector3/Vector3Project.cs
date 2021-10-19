using UnityEngine;
public class Vector3Project : MonoBehaviour
{
    public Transform vector;
    public Transform normal;
    public Transform result;
    void Update()
    {
        // result.position = Vector3.Project(vector.position, normal.forward);
        // Debug.DrawRay(normal.position, result.position*10, Color.blue);
        // Debug.DrawRay(normal.position, vector.position, Color.red);
        // Debug.DrawRay(vector.position, result.position-vector.position, Color.blue);

        result.position = Vector3.Project(vector.position - normal.position, normal.forward) + normal.position;
        Debug.DrawRay(normal.position, (result.position - normal.position)*10, Color.blue);
        Debug.DrawRay(normal.position, vector.position - normal.position, Color.red);
        Debug.DrawRay(vector.position, result.position - vector.position, Color.blue);
    }
}