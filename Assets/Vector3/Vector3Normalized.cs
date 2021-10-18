using UnityEngine;
using UnityEngine.UI;
public class Vector3Normalized : MonoBehaviour
{
    public Transform point1;
    public Transform target;
    public Text text1;
    public Text text2;
    void Update()
    {
        point1.position = target.position.normalized;
        text1.text = point1.position.ToString();
        text2.text = point1.position.x + " - " + point1.position.y + " - " + point1.position.z;
    }
}
