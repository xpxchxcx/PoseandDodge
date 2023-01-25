using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroAudio : MonoBehaviour
{
    public AudioSource introSound;
    // Start is called before the first frame update
    private void Awake()
    {
        introSound.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (introSound.isPlaying == false)
        {
            playMusic();
        }
    }

    void playMusic()
    {
        introSound.Play();
    }
}
