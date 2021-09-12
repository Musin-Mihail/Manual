using UnityEngine;
public class ObjectFindObjectsOfType : MonoBehaviour
{
    void Start()
    {
        var foundGameObjects = FindObjectsOfType<GameObject>(true);
        var foundGameObjects2 = FindObjectsOfType(typeof(GameObject), true);
        Debug.Log(foundGameObjects + " : " + foundGameObjects.Length);
        Debug.Log(foundGameObjects2 + " : " + foundGameObjects2.Length);
    }
}