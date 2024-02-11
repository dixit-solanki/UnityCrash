using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{

    // two clips, perhaps songs for the game
    public AudioClip song1;
    public AudioClip song2;

    private AudioSource audioSource;
    private bool paused1;
    private bool paused2;

    // both songs are in paused state
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        paused1 = true;
        paused2 = true;
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 200, 100), "Play song1"))
        {
            if (paused1 && paused2)
            {
                audioSource.clip = song1;
                audioSource.Play(0);
                paused1 = false;
            }
        }

        if (GUI.Button(new Rect(250, 10, 200, 100), "Pause song1"))
        {
            if (paused1 == false)
            {
                audioSource.Pause();
                paused1 = true;
            }
        }

        if (GUI.Button(new Rect(10, 180, 200, 100), "Play song2"))
        {
            if (paused2 && paused1)
            {
                audioSource.clip = song2;
                audioSource.Play(0);
                paused2 = false;
            }
        }

        if (GUI.Button(new Rect(250, 180, 200, 100), "Pause song2"))
        {
            if (paused2 == false)
            {
                audioSource.Pause();
                paused2 = true;
            }
        }
    }
}
