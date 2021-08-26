using UnityEngine;
public class TransformFind : MonoBehaviour
{
    public GameObject cube;
    void Start()
    {
        cube = transform.Find("Cube").gameObject;
    }
}