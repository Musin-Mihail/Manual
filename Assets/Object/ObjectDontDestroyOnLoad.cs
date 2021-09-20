using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class ObjectDontDestroyOnLoad : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        StartCoroutine(ChangeScene());
    }
    IEnumerator ChangeScene()
    {
        while(true)
        {
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene("NewScene1");
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene("NewScene2");
        }
    }
}