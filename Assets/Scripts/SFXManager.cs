using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{

   public AudioClip eggHit;
   public AudioClip botones;
   public AudioClip openEgg;

    private AudioSource source;
    // Start is called before the first frame update
    void Awake()
    {
       source = GetComponent<AudioSource>(); 
    }

    public void EggHitSound()
    {
        source.PlayOneShot(eggHit);
    }

   public void ButtonSound()
    {
        source.PlayOneShot(botones);
    }

    public void OpenEggSound()
    {
        source.PlayOneShot(openEgg);
    }

}
