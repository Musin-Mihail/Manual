using UnityEngine;
public class QuaternionRotateTowards : MonoBehaviour
{
    public Transform object1;
    public Transform object2;
    void Update()
    {
        object1.rotation = Quaternion.RotateTowards(object1.rotation,object2.rotation, 0.1f);
        Debug.DrawLine(object1.position, object1.position + object1.up*5, Color.green);
        Debug.DrawLine(object2.position, object2.position + object2.up*5, Color.green);
    }
}