using UnityEngine;
public class ObjectInstantiate : MonoBehaviour
{
    public GameObject prefab;
    public GameObject parent;
    void Start()
    {
        Vector3 vector = new Vector3 (1,2,3);
        Instantiate(prefab, vector, Quaternion.identity, parent.transform);
    }
}