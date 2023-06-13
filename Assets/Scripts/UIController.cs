using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public GameObject ui;
    bool paused = false;
    // Start is called before the first frame update
    void Start()
    {
        ui.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale == 1)
        {
            paused = false;
        }
        else
        {
            paused = true;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(paused == false)
            {
                Time.timeScale = 0;
                ui.SetActive(true);
                paused = true;
            }
            else
            {
                Time.timeScale = 1;
                ui.SetActive(false);
                paused = false;
            }
        }

    }
   
}
