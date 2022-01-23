using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ThreeInARow2 : MonoBehaviour
{
    List<Transform> listSphere;
    public List<Transform> wayList;
    public List<Transform> newList;
    public GameObject prefab;
    public List<Material> materials;
    public List<int> layers;
    float fps;
    public Transform StartPoint;
    public Transform FinishPoint;
    public int TESTTEST = 0;
    public int maxCount = 15;
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
                    StartSearch(FinishPoint);
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
            wayList.Clear();
            TESTTEST = 0;
            maxCount = 15;
        }
    }
    void StartSearch(Transform transform)
    {
        // newList = new List<Transform>(listSphere);
        newList = listSphere.OrderBy(x => Vector3.Distance(x.position, FinishPoint.position)).ToList();
        List<Transform> newList2 = new List<Transform>();
        SearchWay(StartPoint, 1, newList2);
        StartCoroutine(ColorSphere());
    }
    IEnumerator ColorSphere()
    {
        foreach (var sphere in wayList)
        {
            yield return new WaitForSeconds(0.05f);
            sphere.GetComponent<MeshRenderer>().material = materials[1];
        }
        StartPoint.GetComponent<MeshRenderer>().material = materials[2];
        FinishPoint.GetComponent<MeshRenderer>().material = materials[2];
    }
    void SearchWay(Transform startPosition, int count, List<Transform> listTransform)
    {
        count++;
        if (count < maxCount && TESTTEST < 200000)
        {
            TESTTEST++;
            List<Transform> temp = new List<Transform>();
            for (int i = 0; i < newList.Count; i++)
            {
                float distance1 = Vector3.Distance(startPosition.position, newList[i].position);
                if (distance1 < 1.1f)
                {
                    if (newList[i] == FinishPoint)
                    {
                        maxCount = count;
                        print("find");
                        Compare(listTransform);
                    }
                    else
                    {
                        if (listTransform.Contains(newList[i]) == false)
                        {
                            List<Transform> newList2 = new List<Transform>(listTransform);
                            newList2.Add(newList[i]);
                            SearchWay(newList[i], count, newList2);
                        }
                    }
                }
            }
        }
    }
    void Compare(List<Transform> listTransform)
    {
        if (wayList.Count != 0)
        {
            if (wayList.Count > listTransform.Count)
            {
                wayList = new List<Transform>(listTransform);
            }
        }
        else
        {
            wayList = new List<Transform>(listTransform);
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