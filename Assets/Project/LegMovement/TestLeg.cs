using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TestLeg : MonoBehaviour
{
    public List<Transform> point;
    public List<Transform> convas1;
    public List<Text> texts;
    public Text textSum;
    void Start()
    {
        StartCoroutine(DrawLine());
        StartCoroutine(MoveText());
        StartCoroutine(MovePoint());
    }
    IEnumerator MovePoint()
    {
        float distanceA;
        float distanceB = 8;
        float distanceC = 12;
        Vector3 vector;
        Vector3 vector2;
        float p;
        float heightToSide;
        while (true)
        {
            distanceA = Vector3.Distance(point[0].position, point[2].position);
            vector = Vector3.Lerp(point[0].position, point[2].position, 0.1f);
            vector2 = Vector3.Cross(point[2].position - point[0].position, Vector3.forward).normalized + vector;
            point[1].position = vector;
            point[1].LookAt(vector2, Vector3.forward);
            p = (distanceA + distanceB + distanceC) / 2;
            heightToSide = (2 / distanceA) * Mathf.Sqrt(p * (p - distanceA) * (p - distanceB) * (p - distanceC));
            // float bisector = (Mathf.Sqrt(distanceB * distanceC * (distanceB + distanceC + distanceA) * (distanceB + distanceC - distanceA)) / (distanceB + distanceC));
            point[1].position += point[1].forward * heightToSide;
            yield return new WaitForSeconds(0.01f);
        }
    }
    IEnumerator DrawLine()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.01f);
            Debug.DrawLine(point[0].position, point[point.Count - 1].position, Color.green, 0.01f);
            for (int i = 0; i < point.Count - 1; i++)
            {
                Debug.DrawLine(point[i].position, point[i + 1].position, Color.red, 0.01f);
            }
        }
    }
    IEnumerator MoveText()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.1f);
            texts[0].text = Vector3.Distance(point[0].position, point[point.Count - 1].position).ToString();
            convas1[0].position = Vector3.Lerp(point[0].position, point[point.Count - 1].position, 0.5f);
            for (int i = 0; i < point.Count - 1; i++)
            {
                texts[i + 1].text = Vector3.Distance(point[i].position, point[i + 1].position).ToString();
                convas1[i + 1].position = Vector3.Lerp(point[i].position, point[i + 1].position, 0.5f);
            }
            float sum = 0;
            for (int i = 0; i < point.Count - 1; i++)
            {
                sum += Vector3.Distance(point[i].position, point[i + 1].position);
            }
            textSum.text = sum.ToString();

        }
    }
    // void Update()
    // {

    // }
}