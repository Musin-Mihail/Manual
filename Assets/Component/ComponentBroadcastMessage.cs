using UnityEngine;
public class ComponentBroadcastMessage : MonoBehaviour
{
    void Start()
    {
        BroadcastMessage("Test", 5.5f, SendMessageOptions.RequireReceiver);
    }
    void Test(float value)
    {
        print("0 - " + value);
    }
}