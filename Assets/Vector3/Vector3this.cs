using UnityEngine;
public class Vector3this : MonoBehaviour
{
    void Start()
    {
        Vector3 vector = new Vector3(0,0,0);
        vector[0] = 1; // x
        vector[1] = 1; // y
        vector[2] = 1; // z

        vector.x = 1; // x
        vector.y = 1; // y
        vector.z = 1; // z
    }
}