using UnityEngine;
public class QuaternionSetLookRotation : MonoBehaviour
{
    public Transform object1;
    public Transform object2;
    public Transform object3;
    public Quaternion quaternion;
    void Update()
    {
        quaternion.SetLookRotation(object1.position, object2.position);
        object3.rotation = quaternion;
        Debug.DrawLine(object3.position, object3.position + object3.up*3, Color.green);
        Debug.DrawLine(object3.position, object3.position + object3.forward*3, Color.blue);
    }
}