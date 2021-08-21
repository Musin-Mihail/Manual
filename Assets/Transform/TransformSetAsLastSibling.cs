using UnityEngine;
using UnityEngine.EventSystems;
public class TransformSetAsLastSibling : MonoBehaviour, IPointerDownHandler
{
    public GameObject Go;
    public void OnPointerDown(PointerEventData Data)
    {
        Go.transform.SetAsLastSibling();
    }
}