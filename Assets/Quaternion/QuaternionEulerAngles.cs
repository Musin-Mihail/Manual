using UnityEngine;
using UnityEngine.UI;
public class QuaternionEulerAngles : MonoBehaviour
{
    public Transform object1;
    public Text text1;
    void Start()
    {
        text1.text = object1.rotation + "\n" + object1.eulerAngles;
        object1.eulerAngles = new Vector3(5,10,20);
        text1.text += "\n" + object1.eulerAngles;
    }
}