using UnityEngine;
public class ObjectBool : MonoBehaviour
{
    void Start()
    {
        if (GetComponent<MeshRenderer>())
        {
            Debug.Log("MeshRenderer");
        }
        if (GetComponent<BoxCollider>() == true)
        {
            Debug.Log("BoxCollider");
        }
        if (GetComponent<Script1>() != null)
        {
            Debug.Log("Script1");
        }

        if (!GetComponent<MeshRenderer>())
        {
            Debug.Log("no MeshRenderer");
        }
        if (GetComponent<BoxCollider>() == false)
        {
            Debug.Log("no BoxCollider");
        }
        if (GetComponent<Script1>() == null)
        {
            Debug.Log("no Script1");
        }
    }
}