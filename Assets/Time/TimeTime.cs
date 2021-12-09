using UnityEngine;
using UnityEngine.UI;
public class TimeTime : MonoBehaviour
{
    [Range(0,1)] public float value;
    public Text text1;
    void Update()
    {
        text1.text = Time.time.ToString() + "\n"
        + Time.timeAsDouble.ToString();
        Time.timeScale = value;
    }
}