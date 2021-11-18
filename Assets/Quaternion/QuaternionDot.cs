using UnityEngine;
using UnityEngine.UI;
public class QuaternionDot : MonoBehaviour
{
    public Transform object1;
    public Transform object2;
    public Text result1;
    public Text resultX;
    public Text resultY;
    public Text resultZ;
    public Text resultW;

    void Update()
    {
        result1.text = Quaternion.Dot(object1.rotation, object2.rotation).ToString();
        resultX.text ="X\n" + object1.rotation.x + "\n" + object2.rotation.x + "\n" + object1.rotation.x * object2.rotation.x;
        resultY.text ="Y\n" + object1.rotation.y + "\n" + object2.rotation.y + "\n" + object1.rotation.y * object2.rotation.y;
        resultZ.text ="Z\n" + object1.rotation.z + "\n" + object2.rotation.z + "\n" + object1.rotation.z * object2.rotation.z;
        resultW.text ="W\n" + object1.rotation.w + "\n" + object2.rotation.w + "\n" + object1.rotation.w * object2.rotation.w;
    }
}