using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroybutton : MonoBehaviour
{
    public GameObject obj;
    public GameObject blue;
    public GameObject red;
    private float time = 0f;
    private void Start()
    {
        blue.transform.position = new Vector3(obj.transform.position.x, obj.transform.position.y);
        red.transform.position = new Vector3(obj.transform.position.x, obj.transform.position.y);

    }
    private void FixedUpdate()
    {
        time += 0.02f;
        if (time >= 0.1f + spawnbutton.period)
        {
            if (PlayerPrefs.GetString("sound") != "no")
            {
                GameObject.Find("click audio no tap or red").GetComponent<AudioSource>().Play();
            }
            spawnbutton.heart -= 1;
            Destroy(obj);
            Instantiate(red);
            spawnbutton.l = 0;

        }
    }
    private void OnMouseUp()
    {
        if(PlayerPrefs.GetString("sound") != "no")
        {
            GameObject.Find("click audio").GetComponent<AudioSource>().Play();
        }
        Destroy(obj);
        Instantiate(blue);
        spawnbutton.count += 1;
        spawnbutton.l = 0;
    }
}



