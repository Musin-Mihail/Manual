using UnityEngine;
public class GameObjectAddComponent : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    void Start()
    {
        object1.AddComponent(typeof(MeshRenderer));
        object2.AddComponent<MeshRenderer>();
    }
}