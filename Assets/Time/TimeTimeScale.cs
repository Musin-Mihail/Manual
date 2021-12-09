using UnityEngine;
using UnityEngine.UI;
public class TimeTimeScale : MonoBehaviour
{
    [Range(0,1)] public float value = 1;
    public Text text1;
    void Update()
    {
        Time.timeScale = value;
        text1.text = Time.time + "\n" + Time.realtimeSinceStartup;
    }
}