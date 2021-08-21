using UnityEngine;
public class TransformSetSiblingIndex : MonoBehaviour
{
    int m_IndexNumber;
    void Start()
    {
        m_IndexNumber = 0;
        transform.SetSiblingIndex(m_IndexNumber);
    }
    void OnGUI()
    {
        if (GUI.Button(new Rect(0, 0, 200, 40), "Add Index Number"))
        {
            if (m_IndexNumber <= transform.GetSiblingIndex())
            {
                m_IndexNumber++;
            }
        }
        if (GUI.Button(new Rect(0, 40, 200, 40), "Minus Index Number"))
        {
            if (m_IndexNumber >= 1)
            {
                m_IndexNumber--;
            }
        }
        if (GUI.changed)
        {
            transform.SetSiblingIndex(m_IndexNumber);
        }
    }
}