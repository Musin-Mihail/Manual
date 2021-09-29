using UnityEngine;
public class TestCode : MonoBehaviour
{
    void Start()
    {
        // GetComponent<MeshRenderer>().enabled = false;
    }
    // void Update()
    // {
        
    // }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("111");
        if (other.name == "Cube")
        {
            GetComponent<MeshRenderer>().enabled = false;
        }
    }
}