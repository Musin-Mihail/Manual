using UnityEngine;
using UnityEngine.UI;
public class QuaternionNormalize : MonoBehaviour
{
    public Transform object1;
    public Text text1;
    public Text text2;
    void Update()
    {
        text1.text = object1.rotation + "\n" + object1.rotation.normalized + "\n" + Quaternion.Normalize(object1.rotation);
    }
}