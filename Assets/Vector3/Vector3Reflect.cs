using UnityEngine;
public class Vector3Reflect : MonoBehaviour
{
    public Transform normal;
    public Transform vector;
    public Transform result;
    void Update()
    {
        result.position = Vector3.Reflect(vector.forward, normal.forward)*10;
        Debug.DrawRay(normal.position, normal.forward*10, Color.green);
        Debug.DrawRay(vector.position, vector.forward*10, Color.red);
        Debug.DrawRay(normal.position, result.position, Color.blue);
    }
}