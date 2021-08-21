using UnityEngine;
public class TransformTransformDirection : MonoBehaviour
{
    public GameObject Sphere;
    public Vector3 vector;
    void Update()
    {
        Sphere.transform.position = transform.TransformDirection(vector);
    }
}