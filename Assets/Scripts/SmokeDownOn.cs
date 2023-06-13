using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeDownOn : MonoBehaviour
{
    public GameObject gameObject;
    AudioSource audioSource;
    // Update is called once per frame
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
        if (dy == 1)
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
