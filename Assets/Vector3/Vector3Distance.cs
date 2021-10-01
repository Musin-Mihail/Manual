using UnityEngine;
using UnityEngine.UI;
public class Vector3Distance : MonoBehaviour
{
    public GameObject panel;
    public Text textDistance;
    public Transform point1;
    public Transform point2;
    void Update()
    {
        panel.transform.position = Vector3.Lerp(point1.position,point2.position, 0.5f) - panel.transform.forward;
        textDistance.text = Vector3.Distance(point1.position,point2.position).ToString();
    }
}