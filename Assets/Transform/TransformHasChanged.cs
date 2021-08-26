using UnityEngine;
public class TransformHasChanged : MonoBehaviour
{
    void Update()
    {
        if (transform.hasChanged)
        {
            print("The transform has changed!");
            transform.hasChanged = false;
        }
    }
}