using UnityEngine;
public class GameObjectFindWithTag : MonoBehaviour
{
    void Start()
    {
        GameObject object1 = GameObject.FindWithTag("Player");
        print(object1.name);
    }
}