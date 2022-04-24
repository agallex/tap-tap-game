using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class lose : MonoBehaviour
{
    public static int ads = 3;
    public GameObject losebanner;
    public GameObject buttonnew;
    public static bool advert = true;
    
    private void Update()
    {
        if(spawnbutton.lose == false)
        {
            losebanner.SetActive(true);
            buttonnew.SetActive(true);
            if (advert == true)
            {
                advert = false;
                if (ads == 3)
                {
                    ads = 0;
                    if (Advertisement.IsReady())
                    {
                        Advertisement.Show("video");
                    }
                }
                ads += 1;
            }
        }
    }
}
