using UnityEngine;
public class GameObjectConstructor : MonoBehaviour
{
    void Start()
    {
        GameObject obgect1 = new GameObject();
        GameObject obgect2 = new GameObject("obgect2");
        GameObject obgect3 = new GameObject("obgect3", typeof(MeshRenderer), typeof(MeshFilter));
    }
}