using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class Music_Manager : MonoBehaviour
{
    static bool AudioBegin = false;
    public int restSeconds = 0; 
    // Start is called before the first frame update
    void Awake()
    {
        if (!AudioBegin)
        {
            GetComponent<AudioSource>().Play();
            DontDestroyOnLoad(gameObject);
            AudioBegin = true;
        }
    }
   void Update()
    {
        if (restSeconds == 4)
        {
            AudioBegin = true;
        }

        if (Application.loadedLevelName == "Game Scene")
        {
            GetComponent<AudioSource>().Stop();
            AudioBegin = false;
        }
    }
}