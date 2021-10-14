using UnityEngine;
public class Vector3Scale : MonoBehaviour
{
    void Start()
    {
        Vector3 point1 = new Vector3 (2,3,4);
        Vector3 point2 = new Vector3 (2,2,2);
        Vector3 point3 = Vector3.Scale(point1,point2);
        print(point3);

        point3.Scale(point2);
        print(point3);
    }
}