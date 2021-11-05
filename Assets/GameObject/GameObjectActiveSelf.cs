using UnityEngine;
public class GameObjectActiveSelf : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    void Start()
    {
        print(object1.activeSelf);
        print(object2.activeSelf);
    }
}