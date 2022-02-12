using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class ThreeInARow2 : MonoBehaviour
{
    List<Transform> listSphere;
    List<Transform> tempListSphere;
    public List<Transform> wayList;
    public GameObject prefab;
    public List<Material> materials;
    public Transform StartPoint;
    public Transform FinishPoint;
    void Start()
    {
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
        }
    }
    void StartSearch(Transform transform)
    {
        tempListSphere = listSphere.OrderBy(x => Vector3.Distance(x.position, FinishPoint.position)).ToList();
        Transform tempSphere = SearchWay(StartPoint);
        if (tempSphere != null)
        {
            wayList.Add(tempSphere);
            wayList.Add(FinishPoint);
        }
        StartCoroutine(ColorSphere());
    }
    void CompareSphere(Transform sphere)
    {
        int index = tempListSphere.IndexOf(sphere);
        tempListSphere.RemoveAt(index);
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
    Transform SearchWay(Transform startPosition)
    {
        CompareSphere(startPosition);
        for (int i = 0; i < tempListSphere.Count; i++)
        {
            Transform tempListSphere2 = tempListSphere[i];
            float distance1 = Vector3.Distance(startPosition.position, tempListSphere2.position);
            if (distance1 < 1.1f)
            {
                if (tempListSphere2 == FinishPoint)
                {
                    print("Нашёл");
                    return tempListSphere2;
                }
                else
                {
                    Transform tempSphere = SearchWay(tempListSphere2);
                    if (tempSphere != null)
                    {
                        wayList.Add(tempSphere);
                        return tempListSphere2;
                    }
                }
            }
        }
        return null;
    }
    IEnumerator CreatePool()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int z = -5; z <= 5; z++)
            {
                for (int x = -5; x <= 5; x++)
                {
                    Vector3 vector = new Vector3(x, 5, z);
                    CreateSphere(vector);
                }
            }
            yield return new WaitForSeconds(0.5f);
        }
    }
    void CreateSphere(Vector3 vector)
    {
        GameObject sphere = Instantiate(prefab, vector, Quaternion.identity);
        sphere.GetComponent<MeshRenderer>().material = materials[0];
        listSphere.Add(sphere.transform);
    }
}