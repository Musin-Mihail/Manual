using UnityEngine;
public class Vector3Dot : MonoBehaviour
{
    public Transform vector1;
    public Transform vector2;
    public Transform result;
    Vector3 newVector;
    void Update()
    {
        newVector.Set(0,0,Vector3.Dot(vector1.position, vector2.position));
        result.position = newVector;
    }
}