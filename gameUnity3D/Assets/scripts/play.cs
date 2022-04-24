using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class play : MonoBehaviour
{
    public GameObject fonmenu;
    public GameObject tutorial;
    public GameObject picturetutorial;
    public GameObject back;
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
        spawnbutton.lose = true;
        lose.advert = true;
        spawnbutton.l = 0;
        spawnbutton.heart = 3;
        spawnbutton.period = 2f;
        spawnbutton.count = 0;
        Destroy(fonmenu);
        Destroy(gameObject);
    }
}
