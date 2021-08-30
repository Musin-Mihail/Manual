using UnityEngine;
public class TransformInverseTransformPoint : MonoBehaviour
{
    public GameObject cube;
    public Vector3 cubevector;
    public Vector3 vector;
    void Update()
    {
        cubevector = cube.transform.position;
        cube.transform.position = transform.InverseTransformPoint(vector);
    }
}