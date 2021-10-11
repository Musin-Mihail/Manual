using UnityEngine;
public class Vector3Operator : MonoBehaviour
{
    void Start()
    {
        Vector3 point1 = new Vector3(1,2,3);
        Vector3 point2 = new Vector3(2,2,2);
        print(point1 - point2);  // (-1.0, 0.0, 1.0)
        print(point1 + point2); // (3.0, 4.0, 5.0)
        print(point1 * 2); // (2.0, 4.0, 6.0)
        print(point1 / 2); // (0.5, 1.0, 1.5)
        print(point1 == point2); // False
        print(point1 != point2); // True
    }
}