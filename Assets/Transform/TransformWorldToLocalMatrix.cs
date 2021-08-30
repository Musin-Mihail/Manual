using UnityEngine;

public class TransformWorldToLocalMatrix : MonoBehaviour
{
    void Start()
    {
        Debug.Log(transform.worldToLocalMatrix);
        Debug.Log(transform.localToWorldMatrix);
        Debug.Log(transform.localToWorldMatrix.m00);
        Debug.Log(transform.localToWorldMatrix.m01);
        Debug.Log(transform.localToWorldMatrix.m02);
        Debug.Log(transform.localToWorldMatrix.m03);
        Debug.Log(transform.localToWorldMatrix.m10);
        Debug.Log(transform.localToWorldMatrix.m11);
        Debug.Log(transform.localToWorldMatrix.m12);
        Debug.Log(transform.localToWorldMatrix.m13);
        Debug.Log(transform.localToWorldMatrix.m20);
        Debug.Log(transform.localToWorldMatrix.m21);
        Debug.Log(transform.localToWorldMatrix.m22);
        Debug.Log(transform.localToWorldMatrix.m23);
        Debug.Log(transform.localToWorldMatrix.m30);
        Debug.Log(transform.localToWorldMatrix.m31);
        Debug.Log(transform.localToWorldMatrix.m32);
        Debug.Log(transform.localToWorldMatrix.m33);
    }
}