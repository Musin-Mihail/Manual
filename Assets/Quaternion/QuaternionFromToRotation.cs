using UnityEngine;
using System.Collections;
public class QuaternionFromToRotation : MonoBehaviour
{
    public Transform object1;
    public Transform object2;
    public Transform object3;
    public GameObject point;
    float align1;
    public Transform parent1;
    public Transform point1;
    public Transform point2;
    void Start()
    {
        align1 = Vector3.Angle(object1.position, object2.position);
        print(align1);
        Quaternion quaternion1 = Quaternion.FromToRotation(object1.position, object2.position);
        StartCoroutine(CreateObject(object3,quaternion1, 5));
    }
    void Update()
    {
        Debug.DrawLine(Vector3.zero, object1.position, Color.red);
        Debug.DrawLine(Vector3.zero, object2.position, Color.red);

        Debug.DrawLine(Vector3.zero, point1.position, Color.green);
        Debug.DrawLine(Vector3.zero, point2.position, Color.green);
    }
    IEnumerator CreateObject(Transform _object, Quaternion quaternion1, int distans)
    {
        point1.position = ((_object.up + _object.forward + _object.right) / 3)*distans;
        while (align1 != Quaternion.Angle(Quaternion.identity, _object.rotation))
        {
            yield return new WaitForSeconds(0.01f);
            _object.rotation = Quaternion.RotateTowards(_object.rotation, quaternion1, 1);
            Vector3 vector2 = (_object.up + _object.forward + _object.right) / 3;
            Instantiate(point, vector2*distans, Quaternion.identity, parent1);
        }
        point2.position = ((_object.up + _object.forward + _object.right) / 3)*distans;
        print(Quaternion.Angle(Quaternion.identity, _object.rotation));
    }
}