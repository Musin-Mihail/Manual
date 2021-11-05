using UnityEngine;
public class GameObjectCreatePrimitive : MonoBehaviour
{
    void Start()
    {
        GameObject plane = GameObject.CreatePrimitive(PrimitiveType.Plane);
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        GameObject capsule = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        GameObject quad = GameObject.CreatePrimitive(PrimitiveType.Quad);
        cube.transform.position = new Vector3(0, 0.5f, 0);
        sphere.transform.position = new Vector3(0, 1.5f, 0);
        capsule.transform.position = new Vector3(2, 1, 0);
        cylinder.transform.position = new Vector3(-2, 1, 0);
        quad.transform.position = new Vector3(0, 2.5f, 0);
    }
}