using UnityEngine;
using UnityEngine.UI;
public class Vector3Magnitude : MonoBehaviour
{
    public Transform point1;
    public Transform point2;
    Vector3 vector1;
    public Text text1;
    void Update()
    {
        // text1.text = point1.position.magnitude.ToString();

        // text1.text = point1.position.magnitude + "\n" + Vector3.Distance(Vector3.zero, point1.position);

        vector1 = point1.position - point2.position;
        text1.text = vector1.magnitude + "\n" + Vector3.Distance(point1.position, point2.position);
    }
}
