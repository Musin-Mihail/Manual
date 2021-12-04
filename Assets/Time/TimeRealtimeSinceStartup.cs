using UnityEngine;
using UnityEngine.UI;
public class TimeRealtimeSinceStartup : MonoBehaviour
{
    public Text test1;
    void Update()
    {
        test1.text = Time.realtimeSinceStartup + "\n"
        + Time.realtimeSinceStartupAsDouble;
    }
}