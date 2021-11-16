using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class QuaternionAngle : MonoBehaviour
{
    public GameObject prefab1;
    public Transform vector1;
    public Transform vector2;
    public Text text1;
    float angle = 100;
    Vector3 vector;
    void Start()
    {
        StartCoroutine(Test());
    }
    void Update()
    {
        Debug.DrawRay(vector1.position, vector1.forward*10, Color.blue);
        Debug.DrawRay(vector2.position, vector2.forward*10, Color.blue);

        Debug.DrawRay(vector1.position, vector1.right*10, Color.red);
        Debug.DrawRay(vector2.position, vector2.right*10, Color.red);

        Debug.DrawRay(vector1.position, vector1.up*10, Color.green);
        Debug.DrawRay(vector2.position, vector2.up*10, Color.green);

        Debug.DrawRay(vector1.position, vector, Color.white);
    }
    IEnumerator Test()
    {
        while(angle != 0)
        {
            vector = ((vector1.forward*10) + (vector1.right*10) + (vector1.up*10))/3;
            Instantiate(prefab1, vector, Quaternion.identity);

            vector1.rotation = Quaternion.RotateTowards(vector1.rotation, vector2.rotation,5f);

            angle = Quaternion.Angle(vector1.rotation, vector2.rotation);
            text1.text = angle.ToString();
            yield return new WaitForSeconds(0.1f);
        }
    }

}