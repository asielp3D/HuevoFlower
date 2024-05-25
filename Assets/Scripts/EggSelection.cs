using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EggSelection : MonoBehaviour
{
    public string eggName;

    void OnMouseDown()
    {
        PlayerPrefs.SetString("SelectedEgg", eggName);
        SceneManager.LoadScene(3);
    }
}