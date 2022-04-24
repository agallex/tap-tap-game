using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class back : MonoBehaviour
{
    public GameObject picturetutorial;
    public GameObject tutorial;
    public GameObject play;
    public GameObject newlose;
    private void OnMouseUp()
    {
        if (PlayerPrefs.GetString("sound") != "no")
        {
            GameObject.Find("click audio buttons").GetComponent<AudioSource>().Play();
        }
        if (play != null)
        {
            play.GetComponent<BoxCollider2D>().enabled = true;
        }
        else
        {
            newlose.GetComponent<BoxCollider2D>().enabled = true;
        }
        picturetutorial.SetActive(false);
        gameObject.SetActive(false);
        tutorial.SetActive(true);
    }
}
