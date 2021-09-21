using UnityEngine;
public class ObjectDestroyImmediate : MonoBehaviour
{
    public GameObject GO;
    void Start()
    {
        DestroyImmediate(GetComponent<MeshRenderer>().material, true);
        DestroyImmediate(GetComponent<Script1>(), true);
        DestroyImmediate(GO, true);
    }
}