using UnityEngine;
public class TransformRoot : MonoBehaviour
{
    void Start()
    {
        Debug.Log(transform.root.name);
    }
}