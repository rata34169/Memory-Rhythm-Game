using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    public GameObject camera;
    public AudioSource music;

    private bool start;

    void Start()
    {
        music = camera.GetComponent<AudioSource>();
        music.Pause();
        start = false;
    }

    void Update()
    {
        if(!start)
        {
            if (Input.anyKeyDown)
            {
                music.Play();
                start = true;
            }
        }
    }
}
