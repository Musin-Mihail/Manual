using UnityEngine;
using UnityEngine.SceneManagement;
public class GameObjectScene : MonoBehaviour
{
    public GameObject object1;
    void Start()
    {
        print(object1.scene.name);
        Scene scene = object1.scene;
        print(scene.path);
    }
}