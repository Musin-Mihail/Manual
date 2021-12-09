using UnityEngine;
public class QuaternionSet : MonoBehaviour
{
    Quaternion quaternion1;
    public Transform object1;
    void Start()
    {
        quaternion1.Set(0,0,0,0);
        print(quaternion1);
        object1.rotation = quaternion1;
        print(object1.rotation);

        quaternion1.Set(10,10,10,10);
        print(quaternion1);
        object1.rotation = quaternion1;
        print(object1.rotation);

        quaternion1.Set(111,222,333,444);
        print(quaternion1);
        object1.rotation = quaternion1;
        print(object1.rotation);
    }
}