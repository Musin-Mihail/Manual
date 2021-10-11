using UnityEngine;
public class Vector3MaxMin : MonoBehaviour
{
    public Transform point1;
    public Transform point2;
    public Transform result;
    void Update()
    {
        // result.position = Vector3.Max(point1.position, point2.position);
        result.position = Vector3.Min(point1.position, point2.position);
    }
}