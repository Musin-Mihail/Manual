using UnityEngine;
public class Vector3XYZ : MonoBehaviour
{
    void Start()
    {
        Vector3 vector = new Vector3(0,0,0);
        print(vector.x);
        print(vector.y);
        print(vector.z);
        float y = vector.y;
        int x = (int)vector.x;
        x = 5;
        vector.x = x;
    }
}