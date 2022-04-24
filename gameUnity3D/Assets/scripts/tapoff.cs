using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tapoff : MonoBehaviour
{
    public GameObject m_on;
    private void OnMouseUp()
    {
        PlayerPrefs.SetString("sound", "yes");
        gameObject.SetActive(false);
        m_on.SetActive(true);
    }
}
