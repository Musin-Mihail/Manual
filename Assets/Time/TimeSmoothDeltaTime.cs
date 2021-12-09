using System.Collections;
using UnityEngine;
public class TimeSmoothDeltaTime : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(TimeChange());
        StartCoroutine(PrintDeltaTime());
    }
    IEnumerator TimeChange()
    {
        yield return new WaitForSeconds(2);
        print("Start");
        Time.timeScale = 3.0f;
        yield return new WaitForSeconds(0.1f);
        Time.timeScale = 1.0f;
        print("End");
    }
    IEnumerator PrintDeltaTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.001f);
            print(Time.deltaTime + " - " + Time.smoothDeltaTime);
        }
    }
}