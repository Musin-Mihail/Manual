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
        // StartCoroutine(CoefficientSearch());
    }
    IEnumerator CoefficientSearch()
    {
        Vector3 start = point[point.Count - 1].position;
        // Vector3 start2 = point[1].position;
        for (float x = 1; x <= 10; x++)
        {
            start.x = x;
            point[2].position = start;
            Vector3 vector = Vector3.Lerp(point[0].position, point[2].position, 0.5f);
            for (float y = 0; y <= 15; y += 0.05f)
            {
                vector.y = y;
                point[1].position = vector;
                float distance = Vector3.Distance(point[0].position, point[1].position);
                if (distance >= 10)
                {
                    float bisector = (Mathf.Sqrt(10 * 10 * (10 + 10 + x) * (10 + 10 - x)) / (10 + 10));
                    print(x + " : " + y + " : " + bisector);
                    break;
                }
                yield return new WaitForSeconds(0.01f);
            }
            vector.y = 0;
            point[1].position = vector;
            yield return new WaitForSeconds(0.01f);
        }

    }
    IEnumerator MovePoint()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.01f);
            Vector3 vector = Vector3.Lerp(point[0].position, point[2].position, 0.5f);
            Vector3 vector2 = Vector3.Cross(point[2].position - point[0].position, Vector3.forward).normalized + vector;
            point[1].position = vector;
            point[1].LookAt(vector2, Vector3.forward);
            float distanceA = Vector3.Distance(point[0].position, point[2].position);
            float distanceB = 10;
            float distanceC = 10;
            float p = (distanceA + distanceB + distanceC) / 2;
            float heightToSide = (2 / distanceA) * (Mathf.Sqrt(p * (p - distanceA) * (p - distanceB) * (p - distanceC)));
            float bisector = (Mathf.Sqrt(distanceB * distanceC * (distanceB + distanceC + distanceA) * (distanceB + distanceC - distanceA)) / (distanceB + distanceC));
            point[1].position += point[1].forward * heightToSide;
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