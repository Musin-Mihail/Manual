using UnityEngine;
public class QuaternionLerpUnclamped : MonoBehaviour
{
    public Transform object1;
    public Transform object2;
    public Transform object3;
    [Range(-1, 2)] public float value = 0;
    void Update()
    {
        object3.rotation = Quaternion.LerpUnclamped(object1.rotation, object2.rotation, value);
        Debug.DrawLine(object1.position, object1.position + object1.up * 2, Color.green);
        Debug.DrawLine(object2.position, object2.position + object2.up * 2, Color.green);
    }
}