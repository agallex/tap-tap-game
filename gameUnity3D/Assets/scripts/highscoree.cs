using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highscoree : MonoBehaviour
{
    public Text highscore;

    void Update()
    {
        highscore.text = PlayerPrefs.GetInt("highscore").ToString();
    }
}
