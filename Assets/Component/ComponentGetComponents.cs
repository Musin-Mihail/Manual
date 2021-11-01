using UnityEngine;
public class ComponentGetComponents : MonoBehaviour
{
    public GameObject object1;
    void Start()
    {
        Component[] array = object1.GetComponents(typeof(Collider));
        MeshRenderer[] array2 = GetComponents<MeshRenderer>();
        foreach (var item in array)
        {
            print(item);
        }
    }
}