using UnityEngine;
using UnityEngine.UI;
public class TimeDeltaTime : MonoBehaviour
{
    public Text text1;
    void Start()
    {
        Application.targetFrameRate = 1;
    }
    void Update()
    {
        text1.text = Time.deltaTime + "\n" + Time.time;
    }
}