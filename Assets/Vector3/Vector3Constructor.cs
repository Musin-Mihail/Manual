using UnityEngine;
public class Vector3Constructor : MonoBehaviour
{
    void Start()
    {
        Vector3 vector = new Vector3(0,0,0);

        
        int x = 5;
        float y = 7.4f;
        Vector3 vector3 = new Vector3(x-1.54f,y,-12.5f);
    }
}