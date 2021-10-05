using UnityEngine;
public class TestCode : MonoBehaviour
{
    public Transform target;
    public Transform point1;
    public Transform point2;
    public Transform center;
    public Transform result1;
    float maxDistans = 20;
    void Update()
    {
        point2.position = Vector3.MoveTowards(point1.position, target.position, maxDistans);
        center.position = Vector3.Lerp(point1.position, point2.position, 0.5f);
        center.LookAt(point2.position);
        result1.position = center.position + center.right*(maxDistans/2 - Vector3.Distance(center.position,point2.position));
    }
}