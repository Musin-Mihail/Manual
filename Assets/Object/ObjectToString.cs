using UnityEngine;
using UnityEngine.UI;
public class ObjectToString : MonoBehaviour
{
    public Text text;
    void Start()
    {
        Vector3 vector = new Vector3(1.5f,0,56.456f);
        text.text = vector.ToString();
    }
}