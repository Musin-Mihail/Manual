using UnityEngine;
public class ComponentGetComponentsInChildren : MonoBehaviour
{
    void Start()
    {
        Component oneObject = GetComponentInChildren(typeof(MeshRenderer));
        print(oneObject);

        Component[] array = GetComponentsInChildren(typeof(MeshRenderer));
        Component[] array2 = GetComponentsInChildren<MeshRenderer>();
        foreach (var item in array)
        {
            print(item.name);
        }
    }
}