using UnityEngine;
public class TestCode : MonoBehaviour
{
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        gameObject.transform.parent = other.transform;
    }
}