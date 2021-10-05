using UnityEngine;
public class Vector3UpDownRightLeftForwardBackOneZero : MonoBehaviour
{
    void Start()
    {
        transform.position = new Vector3(0, 1, 0);
        transform.position = Vector3.up; //  (0, 1, 0)
        transform.position = Vector3.down; // (0, -1, 0)
        transform.position = Vector3.right; // (1, 0, 0)
        transform.position = Vector3.left; // (-1, 0, 0)
        transform.position = Vector3.forward; // (0, 0, 1)
        transform.position = Vector3.back; // (0, 0, -1)
        transform.position = Vector3.one; // (1, 1, 1)
        transform.position = Vector3.zero; // (0, 0, 0)
    }
}