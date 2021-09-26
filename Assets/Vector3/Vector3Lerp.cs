using UnityEngine;
public class Vector3Lerp : MonoBehaviour
{
    public Transform target;
    public Transform point;
    [Range(-1, 2f)]
    public float value = 0.5f;
    void Update()
    {
        point.position = Vector3.Lerp(transform.position, target.position, value);
    }
}