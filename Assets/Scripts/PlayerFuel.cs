using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerFuel : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider;
    public GameObject jet;
    public GameObject audio;
    public GameObject Player;
    bool work = true;
    public float force = 30f;
    public float Fuel = 30f;
    float dx, dy;
    // Start is called before the first frame update
    void Start()
    {
        slider.value = 1;
    }
    void Update()
    {
        if(work)
        {
            Input.GetAxisRaw("Horizontal");
            Input.GetAxisRaw("Vertical");
            float vx, vy;
            Rigidbody rigidbody = new Rigidbody();
            rigidbody = Player.GetComponent<Rigidbody>();
            rigidbody.AddForce(force * Input.GetAxisRaw("Horizontal") * Time.deltaTime, force * Input.GetAxisRaw("Vertical") * Time.deltaTime, 0);
        }
        slider.value = Fuel / 30;
        float dx = Input.GetAxisRaw("Horizontal");
        float dy = Input.GetAxisRaw("Vertical");
        if(dx == 1 || dx == -1)
        {
            Fuel -= Time.deltaTime;
        }
        if (dy == 1 || dy == -1)
        {
            Fuel -= Time.deltaTime;
        }
        if(Fuel <= 0)
        {
            Fuel = 0;
            work = false;
            jet.SetActive(false);
        }
        if(Fuel > 0)
        {
            work = true;
            jet.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // 相手オブジェクトのタグを調べる
        if (other.gameObject.tag == "Fuel")
        {
            Fuel += 6f;
            Destroy(other.gameObject);
            audio.GetComponent<AudioSource>().Play();
            Score.ScoreInt += 1000;
        }

    }
}
