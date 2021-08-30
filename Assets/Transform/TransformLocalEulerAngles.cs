using UnityEngine;
public class TransformLocalEulerAngles : MonoBehaviour
{
    Vector3 currentEulerAngles;
    public Vector3 vector;
    void Update()
    {
        currentEulerAngles += vector * Time.deltaTime;
        transform.localEulerAngles = currentEulerAngles;
    }
}