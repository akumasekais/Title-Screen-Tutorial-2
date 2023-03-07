using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public AudioManager audioManager;
    public Slider _musicSlider;


    private void Start()
    {
        Debug.Log("finding audio");
        audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
    }


    public void ToggleMusic()
    {
        audioManager.ToggleMusic();
    }
    public void MusicVolume()
    {
        audioManager.MusicVolume(_musicSlider.value);
    }
}
