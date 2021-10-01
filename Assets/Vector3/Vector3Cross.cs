using UnityEngine;
using UnityEngine.UI;
public class Vector3Cross : MonoBehaviour
{
    public Text text;
    public Transform point1;
    public Transform point2;
    public Transform result;
    public Transform plane;
    public Transform newCenter;
    void Start()
    {
        plane.position = newCenter.position;
    }
    void Update()
    {
        // var vector = Vector3.Cross(point1.position, point2.position);
        // text.text = point1.position + "\n" + point2.position + "\n" + vector.ToString();
        // result.position = vector.normalized;
        // plane.LookAt(result);

        var vector = Vector3.Cross(point1.position - newCenter.position, point2.position - newCenter.position);
        text.text = point1.position + "\n" + point2.position + "\n" + vector.ToString();
        result.position = vector.normalized + newCenter.position;
        plane.LookAt(result);
    }
}