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
        while (true)
        {
            //Просходит смещение по Z. При этом меняеться длина отрезков. Отрезки должды быть всегда одного размера.
            yield return new WaitForSeconds(0.01f);
            Vector3 vector = Vector3.Lerp(point[0].position, point[2].position, 0.5f);
            Vector3 vector2 = Vector3.Cross(point[2].position - point[0].position, Vector3.forward).normalized + vector;
            point[1].position = vector;
            point[1].LookAt(vector2, Vector3.forward);
            float distance = Vector3.Distance(point[0].position, point[2].position);
            point[1].position += point[1].forward * (10 - (distance / 2));
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