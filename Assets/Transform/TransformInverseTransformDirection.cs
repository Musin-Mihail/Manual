using UnityEngine;
public class TransformInverseTransformDirection : MonoBehaviour
{
    public GameObject cube;
    public Vector3 cubevector;
    public Vector3 vector;
    void Update()
    {
        cubevector = cube.transform.position;
        cube.transform.position = transform.InverseTransformDirection(vector);
    }
}