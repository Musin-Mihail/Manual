using UnityEngine;
public class OtherCompareTag : MonoBehaviour
{
    public Transform Player;
    void Start()
    {
        var check = CompareTag("Player");
        print(check);
        print(Player.CompareTag("Player"));
    }
}