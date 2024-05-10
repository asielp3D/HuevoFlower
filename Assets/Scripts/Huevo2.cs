using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Huevo2 : MonoBehaviour
{
    [SerializeField]private GameObject _brokenEggPrefab;

    [SerializeField]private float eggHealth = 10;
    [SerializeField]private Slider healthSlider;

    // Start is called before the first frame update
    void Start()
    {
        healthSlider.maxValue=eggHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && eggHealth >= 0) 
        {
          EggHit();
        }  
    }

    void EggHit()
    {
        if(eggHealth > 0) 
        {
            eggHealth -= 1; 
            healthSlider.value -=1;

            if(eggHealth == 0)
            {
                Instantiate(_brokenEggPrefab, transform.position, Quaternion.identity);
                Destroy(this.gameObject);
            }
        }  
    }
}

