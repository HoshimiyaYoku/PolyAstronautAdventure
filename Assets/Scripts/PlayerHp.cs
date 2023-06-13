using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHp : MonoBehaviour
{
    public Slider slider;
    public GameObject audio;
    public GameObject FaildUI;

    float HP = 100f;
    // Start is called before the first frame update
    void Start()
    {
        FaildUI.SetActive(false);
        slider.value = 1;
    }
    void Update()
    {
        slider.value = HP/100;
    }
    void OnCollisionEnter(Collision collision)
    {
        // 相手オブジェクトのタグを調べる
        if (collision.gameObject.tag == "Enemy")
        {
            HP -= 10f;
        }
        if(HP <= 0)
        {
            Time.timeScale = 0.1f;
            FaildUI.SetActive(true);
        }

    }
    void OnTriggerEnter(Collider other)
    {
        // 相手オブジェクトのタグを調べる
        if (other.gameObject.tag == "Health")
        {
            HP += 20f;
            audio.GetComponent<AudioSource>().Play();
            Score.ScoreInt += 1000;
            Destroy(other.gameObject);
        }
        if(HP >= 100)
        {
            HP = 100;
        }

    }
}
