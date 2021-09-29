using UnityEngine;
using UnityEngine.UI;
public class Vector3Angle : MonoBehaviour
{
    public Text angle;
    public Transform secondVector3;
    void Update()
    {
        angle.text = Vector3.Angle(transform.forward,secondVector3.forward).ToString();
    }
}