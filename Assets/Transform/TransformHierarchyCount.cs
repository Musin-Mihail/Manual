using UnityEngine;
public class TransformHierarchyCount : MonoBehaviour
{
    void Start()
    {
        // Debug.Log(transform.hierarchyCount);
        Debug.Log(transform.hierarchyCapacity);
        transform.hierarchyCapacity = 20;
        Debug.Log(transform.hierarchyCapacity);
        transform.hierarchyCapacity = 5;
        Debug.Log(transform.hierarchyCapacity);
    }
}