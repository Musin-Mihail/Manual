using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LegMovement : MonoBehaviour
{
    public Transform body;
    public Transform leg;
    int layerMask = 1 << 6;
    void Start()
    {
        StartCoroutine(LegCheckGround());
    }
    IEnumerator LegCheckGround()
    {
        Vector3 oldVector = Vector3.zero;
        Vector3 oldPositionBody = body.position;
        while (true)
        {
            yield return new WaitForSeconds(0.1f);
            RaycastHit _hit;
            if (Physics.Raycast(transform.position, Vector3.down, out _hit, Mathf.Infinity, layerMask))
            {
                float distance = Vector3.Distance(_hit.point, oldVector);

                if (distance > 1.0f)
                {
                    oldVector = _hit.point - (oldPositionBody - body.position).normalized;
                    oldPositionBody = body.position;
                    while (leg.position != oldVector)
                    {
                        leg.position = Vector3.MoveTowards(leg.position, oldVector, 0.2f);
                        yield return new WaitForSeconds(0.01f);
                    }
                }
            }
        }
    }
}