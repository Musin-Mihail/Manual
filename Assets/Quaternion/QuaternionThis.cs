using UnityEngine;
public class QuaternionThis : MonoBehaviour
{
    public Transform object1;
    Quaternion quaternion1;
    float value1;
    void Start()
    {
        print("x - " + object1.rotation[0]);
        print("y - " + object1.rotation[1]);
        print("z - " + object1.rotation[2]);
        print("w - " + object1.rotation[3]);
        
        value1 = object1.rotation[3];
        print("value1 - " + value1);

        quaternion1 = object1.rotation;
        print("x - " + quaternion1[0]);
        print("y - " + quaternion1[1]);
        print("z - " + quaternion1[2]);
        print("w - " + quaternion1[3]);
    }
}