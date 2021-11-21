using UnityEngine;
public class QuaternionInverse : MonoBehaviour
{
    public Transform object1;
    public Transform object2;
    void Update()
    {
        object2.rotation = Quaternion.Inverse(object1.rotation);
    }
}