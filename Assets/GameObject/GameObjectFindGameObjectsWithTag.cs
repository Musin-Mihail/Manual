using UnityEngine;
public class GameObjectFindGameObjectsWithTag : MonoBehaviour
{
    void Start()
    {
        GameObject[] array1 = GameObject.FindGameObjectsWithTag("Player");
        foreach (var item in array1)
        {
            print(item.name);
        }
        print("------");
        print(GameObject.FindGameObjectWithTag("Player").name);
    }
}