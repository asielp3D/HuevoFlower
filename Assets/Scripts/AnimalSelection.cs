using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimalSelection : MonoBehaviour
{
    public string animalName;
    
    void OnMouseDown()
    {
        PlayerPrefs.SetString("SelectedAnimal", animalName);
        SceneManager.LoadScene("escenario");
    }
}
