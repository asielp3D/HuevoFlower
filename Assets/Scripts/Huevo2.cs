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
                EggOpened();
                Instantiate(_brokenEggPrefab, transform.position, Quaternion.identity);
                Destroy(this.gameObject);
            }
        }  
    }

    void EggOpened()
    {
        string selectedAnimal = PlayerPrefs.GetString("SelectedEgg");

        if (selectedAnimal == "lago_1")
        {
            PlayerPrefs.SetString("HuevoLago0", "true");
            GameManager.instance.huevoLago[0] = true;
        }
        else if (selectedAnimal == "lago_2")
        {
            PlayerPrefs.SetString("HuevoLago1", "true");
            GameManager.instance.huevoLago[1] = true;        
        }
        else if (selectedAnimal == "camp_1")
        {
            PlayerPrefs.SetString("HuevoCampamento0", "true");
            GameManager.instance.huevoCampamento[0] = true;
        }
        else if (selectedAnimal == "camp_2")
        {
            PlayerPrefs.SetString("HuevoCampamento1", "true");
            GameManager.instance.huevoCampamento[1] = true;
        }
        else if (selectedAnimal == "nieve_1")
        {
            PlayerPrefs.SetString("HuevoNieve0", "true");
            GameManager.instance.huevoNieve[0] = true;
        }
        else if (selectedAnimal == "nieve_2")
        {
            PlayerPrefs.SetString("HuevoNieve1", "true");
            GameManager.instance.huevoNieve[1] = true;
        }
    }
}

