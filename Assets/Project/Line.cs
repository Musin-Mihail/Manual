using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Line : MonoBehaviour
{
    [Range(0, 1)] public float value;
    List<Transform> line1;
    List<Transform> line2;
    List<Transform> line3;
    List<float> distansLine2;
    List<float> lerpLine2;
    float sumlerpLine2;
    float coefficientLine2;
    int countLine2;
    int countLine3;
    Vector3 point1;
    public Transform object1;
    public Transform object2;
    public Transform object3;
    public Transform parentLine1;
    public Transform parentLine2;
    public Transform parentLine3;
    void Start()
    {
        lerpLine2 = new List<float>();
        distansLine2 = new List<float>();
        line1 = new List<Transform>();
        line2 = new List<Transform>();
        line3 = new List<Transform>();
        parentLine1.GetComponentsInChildren<Transform>(line1);

        RefreshLine2();
        RefreshLine3();

        value = 0;
        StartCoroutine(PlusValue());
    }
    public void RefreshLine2()
    {
        parentLine2.GetComponentsInChildren<Transform>(line2);
        countLine2 = line2.Count;
        lerpLine2.Clear();
        distansLine2.Clear();
        float sumDistanceLine2 = 0;
        for (int i = 1; i < line2.Count - 1; i++)
        {
            float distance = Vector3.Distance(line2[i].position, line2[i + 1].position);
            sumDistanceLine2 += distance;
            distansLine2.Add(distance);
        }
        coefficientLine2 = 1 / sumDistanceLine2;
        foreach (var item in distansLine2)
        {
            sumlerpLine2 += item * coefficientLine2;
            lerpLine2.Add(sumlerpLine2);
        }
        sumlerpLine2 = 0;
    }
    void RefreshLine3()
    {
        parentLine3.GetComponentsInChildren<Transform>(line3);
        countLine3 = line3.Count;
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
    void LerpLine3()
    {
        List<Vector3> list = new List<Vector3>();
        for (int i = 1; i < line3.Count - 1; i++)
        {
            list.Add(Vector3.Lerp(line3[i].position, line3[i + 1].position, value));
        }
        Lerp2Line3(list);
    }
    void Lerp2Line3(List<Vector3> list2)
    {
        if (list2.Count > 2)
        {
            List<Vector3> list = new List<Vector3>();
            for (int i = 0; i < list2.Count - 1; i++)
            {
                list.Add(Vector3.Lerp(list2[i], list2[i + 1], value));
            }
            Lerp2Line3(list);
        }
        else
        {
            object3.position = Vector3.Lerp(list2[0], list2[1], value);
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
        if (parentLine2.childCount != countLine2 - 1)
        {
            RefreshLine2();
        }
        if (parentLine3.childCount != countLine3 - 1)
        {
            RefreshLine3();
        }
        LerpLine1();
        LerpLine2();
        LerpLine3();
        DrawLine1();
        DrawLine2();
        DrawLine3();
    }
    void DrawLine1()
    {
        Debug.DrawLine(line1[1].position, line1[2].position, Color.red, 0.01f);
    }
    void DrawLine2()
    {
        for (int i = 1; i < line2.Count - 1; i++)
        {
            Debug.DrawLine(line2[i].position, line2[i + 1].position, Color.red, 0.01f);
        }
    }
    void DrawLine3()
    {
        point1 = line3[1].position;
        for (float t = 0; t < 1; t += 0.01f)
        {
            List<Vector3> list = new List<Vector3>();
            for (int i = 1; i < line3.Count - 1; i++)
            {
                list.Add(Vector3.Lerp(line3[i].position, line3[i + 1].position, t));
            }
            Draw2Line3(list, t);
        }
    }
    void Draw2Line3(List<Vector3> list2, float value4)
    {
        if (list2.Count > 2)
        {
            List<Vector3> list = new List<Vector3>();
            for (int i = 0; i < list2.Count - 1; i++)
            {
                list.Add(Vector3.Lerp(list2[i], list2[i + 1], value4));
            }
            Draw2Line3(list, value4);
        }
        else
        {
            Vector3 point2 = Vector3.Lerp(list2[0], list2[1], value4);
            Debug.DrawLine(point1, point2, Color.red, 0.01f);
            point1 = point2;
            // Debug.DrawLine(list2[0], list2[1], Color.red, 0.01f);
        }
    }
}