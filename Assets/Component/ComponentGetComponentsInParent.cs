using UnityEngine;
public class ComponentGetComponentsInParent : MonoBehaviour
{
    void Start()
    {
        Component[] array = GetComponentsInParent(typeof(MeshRenderer));
        Component[] array2 = GetComponentsInParent<MeshRenderer>();
        foreach (var item in array)
        {
            print(item.name);
        }
        
        Component array3 = GetComponentInParent<MeshRenderer>();
        print(array3);
    }
}