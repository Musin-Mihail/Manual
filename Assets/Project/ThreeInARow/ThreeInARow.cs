using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeInARow : MonoBehaviour
{
    public Transform startSphere;
    public Transform endSphere;
    public List<Transform> listSphere;
    public List<Transform> tempListSphere;
    public List<GameObject> prefabs;
    public static float fps;
    void OnGUI()
    {
        fps = 1.0f / Time.deltaTime;
        int i = (int)Mathf.Round(fps / 10) * 10;
        if (i >= 60)
        {
            i = 60;
        }
        GUILayout.Label("FPS: " + i);
    }
    void Start()
    {
        Application.targetFrameRate = 60;
        listSphere = new List<Transform>();
        tempListSphere = new List<Transform>();
        StartCoroutine(CreateLine());
    }
    IEnumerator CreateLine()
    {
        // Добавить пул объектов
        yield return new WaitForSeconds(2);
        for (int i = 0; i < 10; i++)
        {
            for (int z = -5; z <= 5; z++)
            {
                for (int x = -5; x <= 5; x++)
                {
                    float value = Random.Range(-0.1f, 0.1f);
                    Vector3 vector = new Vector3(x, 5, z + value);
                    int random = Random.Range(0, 3);
                    if (random == 0)
                    {
                        CreateSphere(prefabs[0], vector);
                    }
                    else if (random == 1)
                    {
                        CreateSphere(prefabs[1], vector);
                    }
                    else if (random == 2)
                    {
                        CreateSphere(prefabs[2], vector);
                    }
                }
            }
            yield return new WaitForSeconds(1);
        }

    }
    void CreateSphere(GameObject prefab, Vector3 vector)
    {
        GameObject sphere = Instantiate(prefab, vector, Quaternion.identity);
        listSphere.Add(sphere.transform);
    }
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit _hit;
            Ray _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(_ray, out _hit, Mathf.Infinity))
            {
                int layer = _hit.transform.gameObject.layer;
                SearchNearestSphere(_hit.transform, layer);
                tempListSphere.Clear();
            }
        }
    }
    void SearchNearestSphere(Transform startPosition, int layer)
    {
        tempListSphere.Add(startPosition);
        foreach (var sphere in listSphere)
        {
            if (sphere.gameObject.layer == layer && sphere.gameObject.activeSelf == true)
            {
                if (Vector3.Distance(startPosition.position, sphere.position) < 1.01f)
                {
                    bool match = false;
                    foreach (var tempSphere in tempListSphere)
                    {
                        if (sphere == tempSphere)
                        {
                            match = true;
                        }
                    }
                    if (match == false)
                    {
                        SearchNearestSphere(sphere, layer);
                    }
                }
            }
        }
        // добавить сферы из пула в замен отключённых.
        foreach (var sphere in tempListSphere)
        {
            sphere.gameObject.SetActive(false);
        }
    }
}