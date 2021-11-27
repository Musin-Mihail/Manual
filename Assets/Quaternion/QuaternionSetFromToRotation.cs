using UnityEngine;
using System.Collections;
public class QuaternionSetFromToRotation : MonoBehaviour
{
    public Transform object1;
    public Transform object2;
    public Transform object3;
    Quaternion endQuaternion;
    Quaternion startQuaternion;
    public Transform object4;
    void Start()
    {
        endQuaternion.SetFromToRotation(object1.position,object2.position);
        print(Vector3.Angle(object1.position,object2.position));
        startQuaternion = object3.rotation;
        endQuaternion *= object3.rotation;
        StartCoroutine(Point());
    }
    void Update()
    {
        Debug.DrawLine(Vector3.zero, object1.position, Color.blue);
        Debug.DrawLine(Vector3.zero, object2.position, Color.blue);
    }
    IEnumerator Point()
    {
        while (object3.rotation != endQuaternion)
        {
            yield return new WaitForSeconds(0.01f);
            object3.rotation = Quaternion.RotateTowards(object3.rotation,endQuaternion, 1.0f);
            Vector3 vector = object3.forward + object3.up + object3.right;
            Instantiate(object4, vector, Quaternion.identity);
        }
        print(Quaternion.Angle(startQuaternion, object3.rotation));
    }
}