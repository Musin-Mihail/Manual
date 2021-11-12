using UnityEngine;
public class GameObjectSetActive : MonoBehaviour
{
    public GameObject object1;
    void Start()
    {
        object1.SetActive(false);
    }
}