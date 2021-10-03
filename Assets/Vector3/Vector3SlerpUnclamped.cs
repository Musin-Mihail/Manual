using UnityEngine;
public class Vector3SlerpUnclamped : MonoBehaviour
{
    public Transform center;
    public Transform point1;
    public Transform point2;
    public Transform result1;
    public Transform result2;
    public Transform result3;
    public Transform result4;
    public Transform result5;
    public Transform result6;
    public Transform result7;
    public Transform result8;
    public Transform result9;
    public Transform result10;
    public Transform point3;
    void Update()
    {
        result1.position = Vector3.SlerpUnclamped(point1.position - center.position, point2.position - center.position, 0.2f) + center.position;
        result2.position = Vector3.SlerpUnclamped(point1.position - center.position, point2.position - center.position, 0.4f) + center.position;
        result3.position = Vector3.SlerpUnclamped(point1.position - center.position, point2.position - center.position, 0.6f) + center.position;
        result4.position = Vector3.SlerpUnclamped(point1.position - center.position, point2.position - center.position, 0.8f) + center.position;
        result5.position = Vector3.SlerpUnclamped(point1.position - center.position, point2.position - center.position, 1.0f) + center.position;
        result6.position = Vector3.SlerpUnclamped(point1.position - center.position, point2.position - center.position, 1.2f) + center.position;
        result7.position = Vector3.SlerpUnclamped(point1.position - center.position, point2.position - center.position, 1.4f) + center.position;
        result8.position = Vector3.SlerpUnclamped(point1.position - center.position, point2.position - center.position, 1.6f) + center.position;
        result9.position = Vector3.SlerpUnclamped(point1.position - center.position, point2.position - center.position, 1.8f) + center.position;
        result10.position = Vector3.SlerpUnclamped(point1.position - center.position, point2.position - center.position, 2.0f) + center.position;
        // point3.position = Vector3.SlerpUnclamped(point1.position - center.position, point2.position - center.position, -1.0f) + center.position;
    }
}