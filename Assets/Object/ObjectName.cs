using UnityEngine;
public class ObjectName : MonoBehaviour
{
    void Start()
    {
        GameObject[] gameObjects = FindObjectsOfType<GameObject>();
        foreach (var GO in gameObjects)
        {
            Debug.Log(GO.name);
        }
        
        Debug.Log(GetComponent<MeshRenderer>().name);
    }
}