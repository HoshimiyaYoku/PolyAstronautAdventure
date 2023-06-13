using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public Text scoretext;
    int finscore;
    // Start is called before the first frame update
    void Start()
    {
        scoretext.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
            scoretext.text = Score.ScoreInt.ToString();
    }
}
