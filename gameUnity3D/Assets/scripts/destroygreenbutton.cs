using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroygreenbutton : MonoBehaviour
{
    public GameObject obj;
    public GameObject green;
    public GameObject red;
    private float time = 0f;
    private void Start()
    {
        green.transform.position = new Vector3(obj.transform.position.x, obj.transform.position.y);
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
        if (PlayerPrefs.GetString("sound") != "no")
        {
            GameObject.Find("click audio").GetComponent<AudioSource>().Play();
        }
        Destroy(obj);
        Instantiate(green);
        spawnbutton.count += 5;
        spawnbutton.l = 0;
    }
}