using UnityEngine;
public class ComponentGetComponent : MonoBehaviour
{
    public GameObject point1;
    void Start()
    {
        // var test1 = point1.GetComponent(typeof(MeshRenderer));
        // var test2 = point1.GetComponent<MeshRenderer>();
        // var test3 = point1.GetComponent("MeshRenderer");

        // var test1 = GetComponent(typeof(MeshRenderer));
        // var test2 = GetComponent<MeshRenderer>();
        // var test3 = GetComponent("MeshRenderer");

        // MeshRenderer test4 = GetComponent(typeof(MeshRenderer));
        // MeshRenderer test4 = GetComponent("MeshRenderer");
        MeshRenderer test4 = GetComponent(typeof(MeshRenderer)) as MeshRenderer;

        // print(test1);
        // print(test2);
        // print(test3);
    }
}