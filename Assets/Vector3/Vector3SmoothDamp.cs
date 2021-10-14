using UnityEngine;
public class Vector3SmoothDamp : MonoBehaviour
{
    public Transform point1;
    public Transform target;
    public Vector3 velocity;
    public float smoothTime = 0.0f;
    public float maxSpeed = 10;
    void Update()
    {
        point1.position = Vector3.SmoothDamp(point1.position, target.position, ref velocity, smoothTime, maxSpeed);
    }
}