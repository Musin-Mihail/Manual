using UnityEngine;
public class ObjectFindObjectOfType : MonoBehaviour
{
    void Start()
    {
        var foundGameObject = FindObjectOfType<GameObject>(true);
        var foundGameObject2 = FindObjectOfType(typeof(GameObject), true);
        Debug.Log(foundGameObject.name);
        Debug.Log(foundGameObject2.name);
        Debug.Log("---------------------");

        var foundGameObjects = FindObjectsOfType<GameObject>();
        foreach (var item in foundGameObjects)
        {
            Debug.Log(item.name);
        }
    }
}