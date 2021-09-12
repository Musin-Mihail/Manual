using System.Collections.Generic;
using UnityEngine;
public class ObjectGetInstanceID : MonoBehaviour
{
    List<GameObject> allObjects = new List<GameObject>();
    void Awake()
    {
        for (int i = 0; i < 10; i++)
        {
            GameObject g = new GameObject("abc" + i.ToString("D3"));
            allObjects.Add(g);
        }
    }
    void Start()
    {
        foreach (GameObject go in allObjects)
        {
            Debug.Log(go.name + " : " + go.GetInstanceID());
        }
    }
}