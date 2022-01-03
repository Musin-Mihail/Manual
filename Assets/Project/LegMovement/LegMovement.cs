using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LegMovement : MonoBehaviour
{
    public Transform body;
    public Transform leg;
    public Transform target;
    int layerMask = 1 << 6;
    Vector3 oldLegVector = Vector3.zero;
    void Start()
    {
        // StartCoroutine(LegCheckGround());
    }
    IEnumerator LegCheckGround()
    {
        RaycastHit _hit;
        Vector3 legTarget;
        while (true)
        {
            if (Vector3.Distance(transform.position, leg.position) > 2.5f)
            {
                legTarget = transform.position + (target.position - transform.position).normalized;
                if (Physics.Raycast(legTarget + Vector3.up * 10, Vector3.down, out _hit, Mathf.Infinity, layerMask))
                {
                    oldLegVector = _hit.point;
                    while (leg.position != _hit.point)
                    {
                        Debug.DrawLine(leg.position, _hit.point, Color.green, 1);
                        leg.position = Vector3.MoveTowards(leg.position, _hit.point, 0.2f);
                        yield return new WaitForSeconds(0.01f);
                    }
                }
            }
            yield return new WaitForSeconds(0.1f);
        }
    }
}