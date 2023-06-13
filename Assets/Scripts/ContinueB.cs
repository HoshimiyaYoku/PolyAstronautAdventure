using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueB : MonoBehaviour
{
    public GameObject ui;
    public void OnClick()
    {
        Time.timeScale = 1;
        ui.SetActive(false);
    }
}
