using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    public float force = 30f;
    public float velocity = 10f; // 速度
    Vector3 Point = Vector3.zero;
    public GameObject bullet;
    public GameObject back;
    public GameObject Audio;
    public Slider slider;
    public float dis = 0;
    public int temscore = 0;
    public Vector3 startPoint;
    float energy = 0;
    void Start()
    {
        Score.ScoreInt = 0;
        Time.timeScale = 1f;
        startPoint = transform.position;
    }
    void Update()
    {
        if(Time.timeScale == 1)
        {
            if(Vector3.Distance(startPoint,transform.position) - dis >= 10)
            {
                Score.ScoreInt += 1000;
                dis += 10;
            }
        }
        /*float dx = Input.GetAxis("Horizontal");
        float dy = Input.GetAxis("Vertical");
        float vx, vy;
        Rigidbody rigidbody = new Rigidbody();
        rigidbody = GetComponent<Rigidbody>();
        vx = rigidbody.velocity.x;
        vy = rigidbody.velocity.y;
        if(dx > 0) { dx = 1; }
        if(dx < 0) { dx = -1; }
        if (dy > 0) { dy = 1; }
        if (dy < 0) { dy = -1; }
        rigidbody.AddForce(force * dx * Time.deltaTime, force * dy * Time.deltaTime, 0);*/
        energy += Time.deltaTime;
        if(energy >= 5)
        {
            energy = 5;
        }
        slider.value = energy / 5;

        if (Input.GetMouseButtonDown(0) && energy >= 5  && Time.timeScale == 1) 
        {
            slider.value = 0;
            energy = 0;
            Point = back.transform.position;
            Point.x += 0.8f;
            Instantiate(bullet, Point, Quaternion.identity);
            Audio.GetComponent<AudioSource>().Play();
        }
    }
}