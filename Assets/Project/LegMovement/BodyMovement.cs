using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BodyMovement : MonoBehaviour
{
    public Transform target;
    public Transform body;
    int layerMask = 1 << 6;
    public List<Transform> legJointList;
    public List<Transform> legJoint2List;
    public List<Transform> legJoint3List;
    public List<Transform> legList;
    public List<Transform> legPoint;
    List<bool> LegMoveCheck;
    Vector3 newBodyPositionY;
    void Start()
    {
        LegMoveCheck = new List<bool>(8);
        for (int i = 0; i < LegMoveCheck.Capacity; i++)
        {
            LegMoveCheck.Add(true);
        }
        for (int i = 0; i < legJointList.Count; i++)
        {
            legList[i].position = legJointList[i].position;
        }
        StartCoroutine(LegCheckGround());
        StartCoroutine(MoveBody());
        StartCoroutine(DrawLegs());
    }
    void Update()
    {
        if (Vector3.Distance(target.position, transform.position) > 2)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, 0.005f);
            newBodyPositionY = new Vector3(transform.position.x, body.position.y, transform.position.z);
            transform.position = newBodyPositionY;
            for (int i = 0; i < legJoint2List.Count; i++)
            {
                // float distanceLeg = Vector3.Distance(legList[i].position, legPoint[i].position);
                Vector3 tempVector = Vector3.Lerp(legList[i].position, legPoint[i].position, 0.6f);
                tempVector.y += 1.3f;
                legJoint2List[i].position = tempVector;

                tempVector = Vector3.Lerp(legList[i].position, legPoint[i].position, 0.1f);
                tempVector.y += 1;
                legJoint3List[i].position = tempVector;
            }
        }
    }
    IEnumerator DrawLegs()
    {
        while (true)
        {
            for (int i = 0; i < legList.Count; i++)
            {
                Debug.DrawLine(legPoint[i].position, legJoint2List[i].position, Color.red, 0.01f);
                Debug.DrawLine(legJoint2List[i].position, legJoint3List[i].position, Color.red, 0.01f);
                Debug.DrawLine(legJoint3List[i].position, legList[i].position, Color.red, 0.01f);
            }
            yield return new WaitForSeconds(0.01f);
        }
    }
    IEnumerator MoveBody()
    {
        while (true)
        {

            yield return new WaitForSeconds(0.1f);
            transform.LookAt(target.position);
            Vector3 sumVector = Vector3.zero;
            foreach (var leg in legList)
            {
                sumVector += leg.position;
            }
            sumVector = sumVector / (legList.Count);
            sumVector.y += 2.0f;
            body.position = sumVector;
            body.transform.LookAt(target.position);
        }
    }
    IEnumerator LegCheckGround()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.01f);
            for (int i = 0; i < legJointList.Count; i++)
            {
                if (LegMoveCheck[i] == true)
                {
                    LegMoveCheck[i] = false;
                    StartCoroutine(MoveLeg(i));
                    yield return new WaitForSeconds(0.1f);
                }
            }
        }
    }
    IEnumerator MoveLeg(int index)
    {
        RaycastHit _hit;
        float distanceLeg = Vector3.Distance(legList[index].position, legPoint[index].position);

        if (distanceLeg > 1.5f)
        {
            Vector3 legTarget = legJointList[index].position + (target.position - transform.position).normalized;
            if (Physics.Raycast(legTarget + Vector3.up * 10, Vector3.down, out _hit, Mathf.Infinity, layerMask))
            {
                // if (Vector3.Distance(_hit.point, legJointList[index].position) > 1.5f)
                // {
                while (legList[index].position != _hit.point)
                {
                    legList[index].position = Vector3.MoveTowards(legList[index].position, _hit.point, 0.2f);

                    yield return new WaitForSeconds(0.01f);
                }
                // }
            }
        }
        LegMoveCheck[index] = true;
    }
}