using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class neww : MonoBehaviour
{
    public GameObject losebanner;
    public GameObject buttonnew;
    public GameObject[] life;
    public GameObject[] lifeoff;
    private void OnMouseUp()
    {
        if (PlayerPrefs.GetString("sound") != "no")
        {
            GameObject.Find("click audio buttons").GetComponent<AudioSource>().Play();
        }
        if (Advertisement.isSupported)
        {
            Advertisement.Initialize("3764787", false);
        }
        life[0].SetActive(true);
        life[1].SetActive(true);
        life[2].SetActive(true);
        losebanner.SetActive(false);
        buttonnew.SetActive(false);
        spawnbutton.lose = true;
        lose.advert = true;
        spawnbutton.l = 0;
        spawnbutton.heart = 3;
        spawnbutton.period = 2f;
        spawnbutton.count = 0;
    }
}

