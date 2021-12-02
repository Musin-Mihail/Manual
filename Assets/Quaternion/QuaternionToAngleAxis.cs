using UnityEngine;
using UnityEngine.UI;
public class QuaternionToAngleAxis : MonoBehaviour
{
    public Transform object1;
    public float angle;
    public Vector3 axis;
    public Text text1;
    void Update()
    {
        object1.rotation.ToAngleAxis(out angle, out axis);
        text1.text = angle + "\n" + axis + "\n" + axis.x + " - " + axis.y + " - " + axis.z;
    }
}