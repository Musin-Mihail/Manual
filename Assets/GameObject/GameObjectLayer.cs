using UnityEngine;
public class GameObjectLayer : MonoBehaviour
{
    public GameObject object1;
    void Start()
    {
        print(object1.layer);
        object1.layer = 4;
        print(object1.layer);
    }
}