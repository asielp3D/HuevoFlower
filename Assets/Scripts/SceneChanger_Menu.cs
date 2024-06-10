using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger_Menu : MonoBehaviour
{
    public SFXManager sfxManager;
    private AudioSource source;
    
    public void Start()
    {
        sfxManager = GameObject.Find("SFXManager").GetComponent<SFXManager>();
    }
    
    public void LoadScene1()
    {
        sfxManager.ButtonSound();
        SceneManager.LoadScene(1);
    }

    public void LoadSceneMenu()
    {
        sfxManager.ButtonSound();
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        sfxManager.ButtonSound();
        // Imprimir un mensaje en la consola para verificar que el botón funciona
        Debug.Log("El juego se cerrará.");

        // Salir del juego
        Application.Quit();
    }
}
