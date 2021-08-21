using System.Collections;
using UnityEngine;
public class TransformParent : MonoBehaviour
{
    public GameObject parent;
    public GameObject child;
    IEnumerator Start()
    {
        while(true)
        {
            child.transform.parent = parent.transform;
            yield return new WaitForSeconds(1);
            child.transform.parent = null;
            yield return new WaitForSeconds(1);
        }
    }
}