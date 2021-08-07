using UnityEngine;
public class TransformDetachChildren : MonoBehaviour
{
    public Transform parent;
    void Start()
    {
        parent.DetachChildren();
    }
}