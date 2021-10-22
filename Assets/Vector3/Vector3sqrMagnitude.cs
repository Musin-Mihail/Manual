using UnityEngine;
using UnityEngine.UI;
public class Vector3sqrMagnitude : MonoBehaviour
{
    public Transform point1;
    public Text text1;
    void Update()
    {
        text1.text = point1.position.sqrMagnitude.ToString();
    }
}
