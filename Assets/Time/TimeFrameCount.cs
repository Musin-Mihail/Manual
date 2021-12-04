using UnityEngine;
using UnityEngine.UI;
public class TimeFrameCount : MonoBehaviour
{
    public Text text1;
    void Start()
    {
        Application.targetFrameRate = 10;
    }
    void Update()
    {
        text1.text = Time.frameCount.ToString();
    }
}