using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeInARow2 : MonoBehaviour
{
    List<Transform> listSphere;
    public List<Transform> wayList;
    public GameObject prefab;
    public List<Material> materials;
    public List<int> layers;
    float fps;
    public Transform StartPoint;
    public Transform FinishPoint;
    int value = 1000;
    List<Transform> tempList1 = new List<Transform>();
    List<Transform> tempList2 = new List<Transform>();
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
        StartCoroutine(CreatePool());
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit _hit;
            Ray _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(_ray, out _hit, Mathf.Infinity))
            {
                if (StartPoint == null)
                {
                    StartPoint = _hit.transform;
                }
                else if (FinishPoint == null)
                {
                    FinishPoint = _hit.transform;
                    SearchWay(StartPoint);
                    StartCoroutine(ColorSphere());

                }
            }
        }
        else if (Input.GetMouseButtonDown(1))
        {
            StartPoint = null;
            FinishPoint = null;
            foreach (var sphere in listSphere)
            {
                sphere.GetComponent<MeshRenderer>().material = materials[0];
            }
            value = 1000;
            wayList.Clear();
        }
    }
    IEnumerator ColorSphere()
    {
        foreach (var sphere in wayList)
        {
            yield return new WaitForSeconds(0.5f);
            sphere.GetComponent<MeshRenderer>().material = materials[1];
        }
    }
    void SearchWay(Transform startPosition)
    {
        List<Transform> temp = new List<Transform>();
        foreach (var sphere in listSphere)
        {
            float distance1 = Vector3.Distance(startPosition.position, sphere.position);
            if (distance1 < 1.01f)
            {
                if (sphere == FinishPoint)
                {
                    if (value > tempList1.Count)
                    {
                        value = tempList1.Count;
                        wayList = new List<Transform>(tempList1);
                        wayList.Add(sphere);
                        break;
                    }
                }
                else
                {
                    temp.Add(sphere);
                }
            }
        }
        foreach (var sphere in temp)
        {
            // List<Transform> tempList2 = new List<Transform>(tempList1);
            bool match = false;
            foreach (var tempSphere in tempList1)
            {
                if (sphere == tempSphere)
                {
                    match = true;
                }
            }
            if (match == false)
            {
                tempList1.Add(sphere);
                sphere.GetComponent<MeshRenderer>().material = materials[2];
                SearchWay2(sphere);
            }
        }
    }
    void SearchWay2(Transform startPosition)
    {
        //Доделать. Нужно удалять проверенный пусть. Как вариант, для каждого пути делать свой лист.
        if (tempList1.Count < 5)
        {
            List<Transform> temp = new List<Transform>();
            foreach (var sphere in listSphere)
            {
                float distance1 = Vector3.Distance(startPosition.position, sphere.position);
                if (distance1 < 1.01f)
                {
                    if (sphere == FinishPoint)
                    {
                        if (value > tempList1.Count)
                        {
                            value = tempList1.Count;
                            wayList = new List<Transform>(tempList1);
                            return;
                        }
                    }
                    else
                    {
                        temp.Add(sphere);
                    }
                }
            }
            foreach (var sphere in temp)
            {
                tempList2 = new List<Transform>(tempList1);
                bool match = false;
                foreach (var tempSphere in tempList1)
                {
                    if (sphere == tempSphere)
                    {
                        match = true;
                    }
                }
                if (match == false)
                {
                    // print(startPosition.name + " - " + sphere.name);
                    tempList1.Add(sphere);
                    sphere.GetComponent<MeshRenderer>().material = materials[2];
                    SearchWay2(sphere);
                }
            }
        }
    }
    IEnumerator CreatePool()
    {
        int value = 1;
        // for (int i = 0; i < 2; i++)
        // {
        for (int z = -5; z <= 5; z++)
        {
            for (int x = -5; x <= 5; x++)
            {
                Vector3 vector = new Vector3(x, 5, z);
                CreateSphere(vector, value);
                value++;
            }
        }
        yield return new WaitForSeconds(0.5f);
        // }
    }
    void CreateSphere(Vector3 vector, int name)
    {
        GameObject sphere = Instantiate(prefab, vector, Quaternion.identity);
        sphere.GetComponent<MeshRenderer>().material = materials[0];
        sphere.gameObject.layer = layers[0];
        sphere.name = name.ToString();
        listSphere.Add(sphere.transform);
    }
    public void Exit()
    {
        Application.Quit();
    }
}