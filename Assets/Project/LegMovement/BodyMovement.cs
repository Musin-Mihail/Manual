using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BodyMovement : MonoBehaviour
{
    public Transform target;
    public Transform body;
    int layerMask = 1 << 6;
    public List<Transform> legJointList;
    public List<Transform> legList;
    public List<Transform> legPoint;
    List<Vector3> oldLegVector;
    void Start()
    {
        oldLegVector = new List<Vector3>(6);
        for (int i = 0; i < oldLegVector.Capacity; i++)
        {
            oldLegVector.Add(Vector3.zero);
        }
        for (int i = 0; i < legJointList.Count; i++)
        {
            legList[i].position = legJointList[i].position;
        }
        StartCoroutine(LegCheckGround());
    }
    void Update()
    {
        if (Vector3.Distance(target.position, transform.position) > 2)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, 0.005f);
            transform.LookAt(target.position);
            RaycastHit _hit;
            if (Physics.Raycast(transform.position, Vector3.down, out _hit, Mathf.Infinity, layerMask))
            {
                Vector3 newPosition = new Vector3(transform.position.x, _hit.point.y + 2, transform.position.z);
                transform.position = newPosition;
                Vector3 sumVector = Vector3.zero;
                foreach (var leg in legList)
                {
                    sumVector += leg.position;
                }
                sumVector = sumVector / (legList.Count);
                sumVector += Vector3.up * 1.5f;
                body.position = sumVector;
                body.rotation = transform.rotation;
            }
        }
    }
    IEnumerator LegCheckGround()
    {
        RaycastHit _hit;
        while (true)
        {
            yield return new WaitForSeconds(0.01f);
            for (int i = 0; i < legJointList.Count; i++)
            {
                if (Vector3.Distance(legJointList[i].position, legList[i].position) > 3.0f)
                {
                    Vector3 legTarget = legJointList[i].position + (target.position - transform.position).normalized;
                    if (Physics.Raycast(legTarget + Vector3.up * 10, Vector3.down, out _hit, Mathf.Infinity, layerMask))
                    {
                        oldLegVector[i] = _hit.point;
                        while (legList[i].position != _hit.point)
                        {
                            legList[i].position = Vector3.MoveTowards(legList[i].position, _hit.point, 0.2f);

                            yield return new WaitForSeconds(0.01f);
                        }
                    }
                }
            }
        }
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        for (int i = 0; i < legList.Count; i++)
        {
            Gizmos.DrawLine(legPoint[i].position, legList[i].position);
        }
    }
}
