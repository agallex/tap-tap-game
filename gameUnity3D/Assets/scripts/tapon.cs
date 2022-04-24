using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tapon : MonoBehaviour
{
    public GameObject m_off;
    private void OnMouseUp()
    {
        if(PlayerPrefs.GetString("sound") != "no")
        {
            GameObject.Find("click audio buttons").GetComponent<AudioSource>().Play();
        }
        PlayerPrefs.SetString("sound", "no");
        gameObject.SetActive(false);
        m_off.SetActive(true);
    }
}
