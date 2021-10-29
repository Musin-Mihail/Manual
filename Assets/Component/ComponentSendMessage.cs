using UnityEngine;
public class ComponentSendMessage : MonoBehaviour
{
    void Start()
    {
        Vector3 vector = new Vector3(1,2,3);
        SendMessage("Test", 5,  SendMessageOptions.RequireReceiver);
    }

    void Test(Vector3 vector)
    {
        print("1");
        print(vector);
    }
}