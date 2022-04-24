using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorial : MonoBehaviour
{
    public GameObject picturetutorial;
    public GameObject back;
    public GameObject play;
    public GameObject newlose;
    private void OnMouseUp()
    {
        if (PlayerPrefs.GetString("sound") != "no")
        {
            GameObject.Find("click audio buttons").GetComponent<AudioSource>().Play();
        }
        if(play != null)
        {
            play.GetComponent<BoxCollider2D>().enabled = false;
        }
        else
        {
            newlose.GetComponent<BoxCollider2D>().enabled = false;
        }
        gameObject.SetActive(false);
        picturetutorial.SetActive(true);
        back.SetActive(true);
    }
}
