using UnityEngine;
public class QuaternionAngleAxis : MonoBehaviour
{
    public Transform object1;
    void Start()
    {
        // object1.rotation = Quaternion.AngleAxis(45, Vector3.up);
        // object1.rotation *= Quaternion.AngleAxis(45, Vector3.up);
        print(Quaternion.AngleAxis(1, Vector3.up));
        print(Quaternion.AngleAxis(1, Vector3.up).x);
        print(Quaternion.AngleAxis(1, Vector3.up).y);
        print(Quaternion.AngleAxis(1, Vector3.up).z);
        print(Quaternion.AngleAxis(1, Vector3.up).w);
    }
    void Update()
    {
        object1.rotation *= Quaternion.AngleAxis(1, Vector3.up);
    }
}