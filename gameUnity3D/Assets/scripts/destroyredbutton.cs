using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyredbutton : MonoBehaviour
{
    public GameObject obj;
    public GameObject red;
    public GameObject notapred;
    private float time = 0f;
    private void Start()
    {
        red.transform.position = new Vector3(obj.transform.position.x, obj.transform.position.y);
        notapred.transform.position = new Vector3(obj.transform.position.x, obj.transform.position.y);

    }
    private void FixedUpdate()
    {
        time += 0.02f;
        if (time >= 0.3 + spawnbutton.period)
        {
            if (PlayerPrefs.GetString("sound") != "no")
            {
                GameObject.Find("click audio").GetComponent<AudioSource>().Play();
            }
            Destroy(obj);
            Instantiate(notapred);
            spawnbutton.count += 1;
            spawnbutton.l = 0;
        }
    }
    private void OnMouseUp()
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
