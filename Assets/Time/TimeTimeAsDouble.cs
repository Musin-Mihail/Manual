using UnityEngine;
using UnityEngine.UI;
public class TimeTimeAsDouble : MonoBehaviour
{
    [Range(0,1)] public float value;
    public Text text1;
    void Update()
    {
        text1.text = Time.timeAsDouble.ToString();
        Time.timeScale = value;
    }
}