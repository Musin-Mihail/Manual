using UnityEngine;
public class ComponentTryGetComponent : MonoBehaviour
{
    public GameObject point1;
    void Start()
    {
        print(point1.TryGetComponent(out MeshRenderer test));
        bool check = point1.TryGetComponent(out MeshRenderer test2);
        print(check);

        if(point1.TryGetComponent(out MeshRenderer meshRenderer))
        {
            meshRenderer.material.color = Color.blue;
        }

        print(TryGetComponent(out MeshRenderer test3));
        print(test3);
    }
}