using UnityEngine;
public class Vector3SignedAngle : MonoBehaviour
{
    public Transform target;
    public Transform object1;
    void Update()
    {
        float angle = Vector3.SignedAngle(target.position - object1.position, object1.forward, Vector3.up);
        print(angle);
        Debug.DrawRay(object1.position, object1.forward * 20, Color.red);
        Debug.DrawRay(object1.position, target.position - object1.position, Color.blue);
    }
}