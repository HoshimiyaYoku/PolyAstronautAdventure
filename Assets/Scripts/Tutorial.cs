using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject TutorialUI;
    public GameObject MainUI;
    // Start is called before the first frame update
    void Start()
    {
        TutorialUI.SetActive(false);
    }
    public void OnClick()
    {
        TutorialUI.SetActive(true);
        MainUI.SetActive(false);
    }
}
