using UnityEngine;
public class ObjectDestroy : MonoBehaviour
{
    public GameObject GO;
    void Start()
    {
        Destroy(GO, 3);
        Destroy(GetComponent<MeshRenderer>().material, 2);
        Destroy(this);
    }
}