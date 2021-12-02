using UnityEngine;
public class QuaternionSlerpUnclamped : MonoBehaviour
{
    public Transform object1;
    public Transform object2;
    public Transform object3;
    public Transform object4;
    [Range(-2, 2)] public float value = 0;
    void Update()
    {
        object3.rotation = Quaternion.SlerpUnclamped(object1.rotation, object2.rotation, value);
        object4.rotation = Quaternion.LerpUnclamped(object1.rotation, object2.rotation, value);

        Debug.DrawLine(object1.position, object1.position + object1.up * 2, Color.green);
        Debug.DrawLine(object2.position, object2.position + object2.up * 2, Color.green);
        Debug.DrawLine(object3.position, object3.position + object3.up * 2, Color.red);
        Debug.DrawLine(object4.position, object4.position + object4.up * 2, Color.blue);
    }
}
