using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class huevo : MonoBehaviour
{
    [SerializeField]private float eggHealth = 10;
    [SerializeField]private Slider healthSlider;
    [SerializeField]private Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        healthSlider.maxValue=eggHealth;
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame

    void Update()
    {
        if(Input.GetButtonDown("Fire1")) 
        {
          EggHit();
        }  
    }

    void EggHit()
    {
         if(eggHealth > 0) 
        {
           eggHealth -= 1; 
           //healthSlider.value -=1;
            _animator.SetBool("BrokeEgg", false);
        }  

        else
        {
            
            _animator.SetBool("BrokeEgg", true);

        }
    }
}

