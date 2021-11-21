using UnityEngine;
public class QuaternionLookRotation : MonoBehaviour
{
    public Transform object1;
    public Transform object2;
    void Update()
    {
        object2.rotation = Quaternion.LookRotation(object1.position, Vector3.down);
        Debug.DrawLine(object2.position, object2.position + object2.forward * 5, Color.blue);
        Debug.DrawLine(object2.position, object2.position + object2.up * 2, Color.green);
    }
}