using UnityEngine;
public class TransformSetPositionAndRotation : MonoBehaviour
{
    public GameObject Cube;
    public Vector3 vector;
    void Update()
    {
        Cube.transform.SetPositionAndRotation(vector, transform.rotation);
    }
}