using UnityEngine;
using UnityEngine.UI;
public class TimeUnscaledDeltaTime : MonoBehaviour
{
    public Text text1;
    public Text text2;
    [Range(0, 1)] public float value = 1;
    void Update()
    {
        text1.text = Time.unscaledDeltaTime + "\n"
        + Time.unscaledTime + "\n"
        + Time.unscaledTimeAsDouble;

        text2.text = Time.deltaTime + "\n"
        + Time.time + "\n"
        + Time.timeAsDouble;

        Time.timeScale = value;
    }
}