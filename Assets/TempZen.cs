using UnityEngine;
public class TempZen : MonoBehaviour
{
    GameObject zemlya;
    void Start()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, 0);
        if (hitColliders.Length != 0)
        {
            Destroy(gameObject);
        }

        if (hitColliders.Length == 0)
        {
            Instantiate(zemlya, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
    // void Start()
    // {
    //     transform.DetachChildren();
    //     Destroy(gameObject);
    // }
}