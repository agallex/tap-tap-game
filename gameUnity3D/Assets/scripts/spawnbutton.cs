using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class spawnbutton : MonoBehaviour
{
    public GameObject[] buttons;
    // Start is called before the first frame update
    private float[] str = { -1.62f, -0.54f, 0.54f, 1.62f };
    private float[] stolb = { 0.12f, -0.96f, -2.04f, -3.12f };
    public static int l = 1;
    public static int heart = 3;
    public static float period = 2f;
    public static int count = 0;
    public static bool lose = true;

    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    { 
        if (heart == 0)
        {
            lose = false;
        }
        else
        {
            if (l == 0)
            {
                l = 1;
                int k;
                k = Random.Range(1, 21);
                if (k == 20)
                {
                    Instantiate(buttons[1], new Vector3(str[Random.Range(0, 3)], stolb[Random.Range(0, 3)]), Quaternion.identity);
                }
                else if (k == 19)
                {
                    Instantiate(buttons[2], new Vector3(str[Random.Range(0, 3)], stolb[Random.Range(0, 3)]), Quaternion.identity);
                }
                else
                {
                    Instantiate(buttons[0], new Vector3(str[Random.Range(0, 3)], stolb[Random.Range(0, 3)]), Quaternion.identity);
                }
                if (period > 0f)
                {
                    period -= 0.0025f;
                }
            }
        }
    }

}
