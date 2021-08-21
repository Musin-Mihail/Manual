using UnityEngine;
public class TransformTransformPoint : MonoBehaviour
{
    public GameObject Sphere;
    public Vector3 vector;
    void Update()
    {
        Sphere.transform.position = transform.TransformPoint(vector);
    }
}