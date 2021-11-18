using UnityEngine;
public class QuaternionEuler : MonoBehaviour
{
    public Transform object1;
    void Start()
    {
        Vector3 vector1 = new Vector3(10, 20, 30);
        Quaternion rotation1 = Quaternion.Euler(10, 20, 30);
        Quaternion rotation2 = Quaternion.Euler(vector1);
        object1.rotation = rotation1;
    }
}