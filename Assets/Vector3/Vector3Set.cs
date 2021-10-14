using UnityEngine;
public class Vector3Set : MonoBehaviour
{
    public Transform point1;
    Vector3 vector;
    public Transform result;
    void Start()
    {
        vector.Set(point1.position.x,point1.position.y,5);
        result.position = vector;
    }
}