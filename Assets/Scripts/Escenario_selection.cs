using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escenario_selection : MonoBehaviour
{
    public string escName;
    
    void OnMouseDown()
    {
        PlayerPrefs.SetString("SelectedESC", escName);
        SceneManager.LoadScene(2);
    }
}
