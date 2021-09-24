using UnityEngine;
public class ObjectOperator : MonoBehaviour
{
    public GameObject GO1;
    public GameObject GO2;
    void Start()
    {
        if(GO1 == GO2)
        {
            Debug.Log("true");
        }

        if(GO1 != GO2)
        {
            Debug.Log("false");
        }

        Debug.Log(GO1 == GO2);
    }
}