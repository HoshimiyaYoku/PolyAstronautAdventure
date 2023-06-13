using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeRightOn : MonoBehaviour
{
    public GameObject gameObject;
    // Update is called once per frame
    AudioSource audioSource;
    void Start()
    {
        gameObject.GetComponent<ParticleSystem>().Stop();
        // AudioSource のインスタンス取得
        audioSource = gameObject.GetComponent<AudioSource>();
    }
    void Update()
    {
        float dx = Input.GetAxisRaw("Horizontal");
        float dy = Input.GetAxisRaw("Vertical");
        if (dx == -1)
        {
            if (!gameObject.GetComponent<ParticleSystem>().isPlaying)
            {
                gameObject.GetComponent<ParticleSystem>().Play();
            }
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            gameObject.GetComponent<ParticleSystem>().Stop();
            audioSource.Pause();
        }
    }
}
