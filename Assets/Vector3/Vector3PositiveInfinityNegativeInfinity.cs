using UnityEngine;
using System.Collections;
public class Vector3PositiveInfinityNegativeInfinity : MonoBehaviour
{
    public Transform point1;
    void Start()
    {
        StartCoroutine(test());
        // Vector3 vector1 = new Vector3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity);
        // print(vector1);
        // Vector3 vector2 = new Vector3(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity);
        // print(vector2);
        // point1.position = vector1;
    }
    IEnumerator test()
    {
        float float1 = 10;
        while(float1 != float.PositiveInfinity)
        {
            float1 *= 1000;
            print(float1);
            yield return new WaitForSeconds(1);
        }
    }
}