using UnityEngine;
public class Vector3MoveTowards : MonoBehaviour
{
    public Transform target;
    public Vector3 targetVector;
    void Update()
    {
        // targetVector = transform.position + Vector3.forward;
        // transform.position = Vector3.MoveTowards(transform.position, targetVector, 0.05f);
        // targetVector = transform.position + transform.forward;
        // transform.position = Vector3.MoveTowards(transform.position, targetVector, 0.05f);
        // transform.position = Vector3.MoveTowards(transform.position, target.position, 0.05f);
        // transform.position = Vector3.MoveTowards(transform.position, -target.position, 0.05f);
        targetVector = transform.position + (transform.position - target.position);
        transform.position = Vector3.MoveTowards(transform.position, targetVector, 0.05f);
    }
}