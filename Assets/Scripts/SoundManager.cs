using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private AudioSource audioSource;

   public AudioClip Music;

    private AudioSource source;

    // Start is called before the first frame update
    void Awake()
    {
       DontDestroyOnLoad(this.gameObject);
       source = GetComponent<AudioSource>();

       source.clip = Music; 
       source.Play(); 
    }

    public void StopBGM()
    {
        source.Stop();
    }

}


