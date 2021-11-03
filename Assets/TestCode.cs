using UnityEngine;
using UnityEngine.UI;
public class TestCode : MonoBehaviour
{
    public Collider collider1;
    public Transform pointLeft;
    public Transform pointRight;
    public Transform pointUp;
    public Transform pointDown;
    public Transform player;
    public Transform target;
    public Transform point55;
    public Transform point66;
    Vector3 vector3 = Vector3.zero;
    Vector3 vector4 = Vector3.zero;
    Transform targetLookAt;
    public Text text1;
    Vector3 newDirection;
    void Start()
    {
        
    }
    void Update()
    {
        player.LookAt(target.position);
        float left = 0;
        float right = 0;
        float leftDistans = 0;
        float rightDistans = 0;

        Vector3 vector1 = collider1.bounds.center;
        Debug.DrawRay(player.position, player.forward*100, Color.green);
        
        vector3.Set(vector1.x + 100, vector1.y,vector1.z);
        pointRight.position = collider1.bounds.ClosestPoint(vector3);
        if(Vector3.SignedAngle(pointRight.position - player.position, player.forward, Vector3.forward) < 0)
        {
            left++;
            leftDistans += Vector3.Distance(player.position,pointRight.position);
            leftDistans += Vector3.Distance(target.position,pointRight.position);
        }
        else
        {
            right++;
            rightDistans += Vector3.Distance(player.position,pointRight.position);
            rightDistans += Vector3.Distance(target.position,pointRight.position);
        }

        vector3.Set(vector1.x - 100, vector1.y,vector1.z);
        pointLeft.position = collider1.bounds.ClosestPoint(vector3);
        if(Vector3.SignedAngle(pointLeft.position - player.position, player.forward, Vector3.forward) < 0)
        {
            left++;
            leftDistans += Vector3.Distance(player.position,pointLeft.position);
            leftDistans += Vector3.Distance(target.position,pointLeft.position);
        }
        else
        {
            right++;
            rightDistans += Vector3.Distance(player.position,pointLeft.position);
            rightDistans += Vector3.Distance(target.position,pointLeft.position);
        }

        vector3.Set(vector1.x, vector1.y + 100,vector1.z);
        pointUp.position = collider1.bounds.ClosestPoint(vector3);
        if(Vector3.SignedAngle(pointUp.position - player.position, player.forward, Vector3.forward) < 0)
        {
            left++;
            leftDistans += Vector3.Distance(player.position,pointUp.position);
            leftDistans += Vector3.Distance(target.position,pointUp.position);
        }
        else
        {
            right++;
            rightDistans += Vector3.Distance(player.position,pointUp.position);
            rightDistans += Vector3.Distance(target.position,pointUp.position);
        }

        vector3.Set(vector1.x, vector1.y - 100,vector1.z);
        pointDown.position = collider1.bounds.ClosestPoint(vector3);
        if(Vector3.SignedAngle(pointDown.position - player.position, player.forward, Vector3.forward) < 0)
        {
            left++;
            leftDistans += Vector3.Distance(player.position,pointDown.position);
            leftDistans += Vector3.Distance(target.position,pointDown.position);
        }
        else
        {
            right++;
            rightDistans += Vector3.Distance(player.position,pointDown.position);
            rightDistans += Vector3.Distance(target.position,pointDown.position);
        }

        if(left > right)
        {
            text1.text = "right " + left + " - " + right;
        }
        else if (left < right)
        {
            text1.text = "left " + left + " - " + right;
        }
        else
        {
            if(leftDistans > rightDistans)
            {
                text1.text = "right " + left + " - " + right;
            }
            else
            {
                text1.text = "left " + left + " - " + right;
            }
        }

        
        left = 0;
        right = 0;
        leftDistans = 0;
        rightDistans = 0;
    }
}