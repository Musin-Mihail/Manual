using UnityEngine;
public class Vector3RotateTowards : MonoBehaviour
{
    public Transform object1;
    public Transform target;
    Vector3 newDirection;
    void Update()
    {
        newDirection = Vector3.RotateTowards(object1.forward, target.position - object1.position,0.01f,10);
        Debug.DrawRay(object1.position, newDirection, Color.red);
        object1.rotation = Quaternion.LookRotation(newDirection);
        object1.position += object1.forward * 0.01f;
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(newDirection + object1.position, 0.25f);
    }
}