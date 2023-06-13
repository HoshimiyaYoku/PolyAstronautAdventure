using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour
{
    public GameObject TutorialUI;
    public GameObject MainUI;
    // Start is called before the first frame update
    public void OnClick()
    {
        TutorialUI.SetActive(false);
        MainUI.SetActive(true);
    }
}
