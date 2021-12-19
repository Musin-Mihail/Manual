using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Line : MonoBehaviour
{
    [Range(0, 1)] public float value;
    public List<Transform> line1;
    public List<Transform> line2;
    public List<Transform> line3;
    public List<float> distansLine2;
    float sum;
    public List<float> lerpLine2;
    float sumlerpLine2;
    float coefficient;
    int countLine2;
    public Transform object1;
    public Transform object2;
    public Transform object3;
    public Transform parentLine1;
    public Transform parentLine2;
    public Transform parentLine3;
    void Start()
    {
        parentLine1.GetComponentsInChildren<Transform>(line1);

        RefreshLine2();

        parentLine2.GetComponentsInChildren<Transform>(line3);

        value = 0;
        StartCoroutine(PlusValue());
    }
    public void RefreshLine2()
    {
        parentLine2.GetComponentsInChildren<Transform>(line2);
        countLine2 = line2.Count;
        distansLine2.Clear();
        lerpLine2.Clear();
        for (int i = 1; i < line2.Count - 1; i++)
        {
            float distans = Vector3.Distance(line2[i].position, line2[i + 1].position);
            sum += distans;
            distansLine2.Add(distans);
        }
        coefficient = 1 / sum;
        foreach (var item in distansLine2)
        {
            sumlerpLine2 += item * coefficient;
            lerpLine2.Add(sumlerpLine2);
        }
        sum = 0;
        sumlerpLine2 = 0;
    }
    void LerpLine1()
    {
        object1.position = Vector3.Lerp(line1[1].position, line1[2].position, value);
    }
    void LerpLine2()
    {
        if (value <= lerpLine2[0])
        {
            float test2 = (1 / (lerpLine2[0])) * value;
            object2.position = Vector3.Lerp(line2[1].position, line2[2].position, test2);
        }
        else
        {
            Lerp2Line2(1);
        }
    }
    void Lerp2Line2(int count)
    {
        if (count < lerpLine2.Count)
        {
            if (value <= lerpLine2[count])
            {
                float test2 = (1 / (lerpLine2[count] - lerpLine2[count - 1])) * (value - lerpLine2[count - 1]);
                object2.position = Vector3.Lerp(line2[count + 1].position, line2[count + 2].position, test2);
            }
            else
            {
                Lerp2Line2(count + 1);
            }
        }
    }
    IEnumerator PlusValue()
    {
        while (value <= 1)
        {
            yield return new WaitForSeconds(0.01f);
            value += 0.01f;
            Move();

        }
        StartCoroutine(MinusValue());
    }
    IEnumerator MinusValue()
    {
        while (value >= 0)
        {
            yield return new WaitForSeconds(0.01f);
            value -= 0.01f;
            Move();
        }
        StartCoroutine(PlusValue());
    }
    void Move()
    {
        if (parentLine2.childCount != countLine2)
        {
            RefreshLine2();
        }
        LerpLine1();
        LerpLine2();
        DrawLine();
    }
    void DrawLine()
    {
        Debug.DrawLine(line1[1].position, line1[2].position, Color.red, 0.01f);
        for (int i = 1; i < line2.Count - 1; i++)
        {
            Debug.DrawLine(line2[i].position, line2[i + 1].position, Color.red, 0.01f);
        }
    }
}