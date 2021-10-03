using UnityEngine;
public class Vector3Slerp : MonoBehaviour
{
    public Transform point1;
    public Transform point2;
    public Transform result1;
    public Transform result2;
    public Transform result3;
    public Transform result4;
    public Transform result5;
    public Transform center;
    void Update()
    {
        result1.position = Vector3.Slerp(point1.position - center.position, point2.position - center.position, 0.1f) + center.position;
        result2.position = Vector3.Slerp(point1.position - center.position, point2.position - center.position, 0.25f) + center.position;
        result3.position = Vector3.Slerp(point1.position - center.position, point2.position - center.position, 0.5f) + center.position;
        result4.position = Vector3.Slerp(point1.position - center.position, point2.position - center.position, 0.75f) + center.position;
        result5.position = Vector3.Slerp(point1.position - center.position, point2.position - center.position, 0.9f) + center.position;
    }
}