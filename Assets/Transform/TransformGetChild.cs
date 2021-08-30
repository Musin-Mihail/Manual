using UnityEngine;
public class TransformGetChild : MonoBehaviour
{
    void Start()
    {
        Debug.Log(transform.GetChild(4).GetChild(2).name);
    }
}