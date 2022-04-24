using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class life : MonoBehaviour
{
    public GameObject[] lifes;
    public GameObject[] lifesoff;
    void Update()
    {
        if(spawnbutton.heart == 2)
        {
            lifes[2].SetActive(false);
        }
        if (spawnbutton.heart == 1)
        {
            lifes[1].SetActive(false);
        }
        if (spawnbutton.heart == 0)
        {
            lifes[0].SetActive(false);
        }
    }
}
