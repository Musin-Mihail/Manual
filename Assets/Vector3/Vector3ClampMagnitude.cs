using UnityEngine;
public class Vector3ClampMagnitude : MonoBehaviour
{
    public GameObject point;
    public GameObject target;
    [Range(0.0f,10.0f)]
    public float radius;
    void Update()
    {
        // point.transform.position = Vector3.ClampMagnitude(target.transform.position, radius);
        // point.transform.position = transform.position + Vector3.ClampMagnitude(target.transform.position, radius);
        point.transform.position = transform.position + Vector3.ClampMagnitude(target.transform.position - transform.position, radius);
    }
}