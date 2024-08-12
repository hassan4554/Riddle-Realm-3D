using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public AudioSource musicSource; // Drag the AudioSource component here in the Inspector
    public AudioClip musicClip; // Drag the music clip here in the Inspector

    void Start()
    {
        if (musicSource == null)
        {
            musicSource = gameObject.AddComponent<AudioSource>();
        }

        musicSource.clip = musicClip; // Assign the music clip to the audio source
        musicSource.loop = true; // Set the music to loop
        musicSource.playOnAwake = true; // Start playing the music when the game starts
        musicSource.volume = 0.5f; // Set the volume (optional, default is 1.0f)
        musicSource.Play(); // Play the music
    }
}
