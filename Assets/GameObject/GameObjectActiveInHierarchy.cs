using UnityEngine;
public class GameObjectActiveInHierarchy : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    void Start()
    {
        print(object1.name + " - " + object1.activeInHierarchy);
        print(object2.name + " - " + object2.activeInHierarchy);
    }
}