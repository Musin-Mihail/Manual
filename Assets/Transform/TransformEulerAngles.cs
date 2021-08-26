using UnityEngine;
public class TransformEulerAngles : MonoBehaviour
{
    public Vector3 currentEulerAngles;
    public Vector3 vector;
    void Start()
    {
        currentEulerAngles = transform.eulerAngles;
    }
    void Update()
    {
        currentEulerAngles += vector * Time.deltaTime;
        transform.eulerAngles = currentEulerAngles;
    }
}