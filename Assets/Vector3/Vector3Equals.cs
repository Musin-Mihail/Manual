using UnityEngine;
public class Vector3Equals : MonoBehaviour
{
    void Start()
    {
        Vector3 point1 = new Vector3(1,1,1);
        Vector3 point2 = new Vector3(1.000001f,1.000001f,1.000001f);

        if(Vector3.Equals(point1,point2))
        {
            print("true");
        }
        else
        {
            print("false");
        }

        print(Vector3.Equals(point1,point2));

        bool some = Vector3.Equals(point1,point2);
        print(some);

        // Vector3 point1 = new Vector3(1,1,1);
        // Vector3 point2 = new Vector3(1.000001f,1.000001f,1.000001f);
        // if(point1 == point2)
        // {
        //     print("true");
        // }
        // else
        // {
        //     print("false");
        // }
    }
}