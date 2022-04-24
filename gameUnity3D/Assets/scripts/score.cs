using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text scorre;
    private void Update()
    {
        scorre.text = spawnbutton.count.ToString();
        if (spawnbutton.count > PlayerPrefs.GetInt("highscore"))
        {
            PlayerPrefs.SetInt("highscore", spawnbutton.count);
        }
    }
}
