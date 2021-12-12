using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TimeTimeSinceLevelLoad : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        StartCoroutine(LoadNewScene());
    }
    void Update()
    {
        print(Time.timeSinceLevelLoad + " - " + Time.timeSinceLevelLoadAsDouble);
    }
    IEnumerator LoadNewScene()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene("Scene1");
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene("Scene2");
        }
    }
}