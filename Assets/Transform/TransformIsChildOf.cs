using UnityEngine;
public class TransformIsChildOf : MonoBehaviour
{
    Material material;
    void Start()
    {
        material = GetComponent<MeshRenderer>().material;
    }
    void OnTriggerEnter(Collider cube)
    {
        if (cube.transform.IsChildOf(transform))
        {
            material.color = Color.blue;
        }
        else
        {
            material.color = Color.red;
        }
    }
}