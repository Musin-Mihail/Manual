using UnityEngine;
public class TransformTransformVector : MonoBehaviour
{
    public GameObject Sphere;
    public Vector3 vector;
    void Update()
    {
        Sphere.transform.position = transform.TransformVector(vector);
    }
}