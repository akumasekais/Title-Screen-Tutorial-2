using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
   
    public Sound[] musicSounds;
    public AudioSource musicSource;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    else
        {
            Destroy(gameObject);
        }

        musicSource = GameObject.Find("Music").GetComponent<AudioSource>();
    }

    private void Start()
    {
        PlayMusic("Music");
    }

    public void PlayMusic (string name)
    {
        Sound s = Array.Find(musicSounds, x => x.name == name);
        if (s != null)
        {
            Debug.Log("Sound not found");
        }

    else
        {
            musicSource.clip = s.clip;
            musicSource.Play();
        }
    }

    public void ToggleMusic()
    {
        musicSource.mute = !musicSource.mute;
    }
    public void MusicVolume (float volume)
    {
        musicSource.volume = volume;
        Debug.Log(volume);
    }
}
