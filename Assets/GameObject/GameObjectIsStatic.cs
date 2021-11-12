using UnityEngine;
public class GameObjectIsStatic : MonoBehaviour
{
    public GameObject object1;
    void Start()
    {
        print(object1.isStatic);
        object1.isStatic = true;
        print(object1.isStatic);
    }
}