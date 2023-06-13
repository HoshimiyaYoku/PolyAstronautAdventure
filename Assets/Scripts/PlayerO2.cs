using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerO2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider;
    public GameObject audio;
    public GameObject FaildUI;

    float O2 = 45f;
    // Start is called before the first frame update
    void Start()
    {
        FaildUI.SetActive(false);
        slider.value = 1;
    }
    void Update()
    {
        slider.value = O2 / 45;
        O2 -= Time.deltaTime;
        if(O2 <= 0)
        {
            Time.timeScale = 0.1f;
            FaildUI.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // 相手オブジェクトのタグを調べる
        if (other.gameObject.tag == "O2")
        {
            O2 += 6f;
            audio.GetComponent<AudioSource>().Play();
            Destroy(other.gameObject);
            Score.ScoreInt += 1000;
        }

    }
}
