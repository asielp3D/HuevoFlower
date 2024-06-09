using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger_Menu : MonoBehaviour
{
    public void LoadScene1()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadSceneMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        // Imprimir un mensaje en la consola para verificar que el botón funciona
        Debug.Log("El juego se cerrará.");

        // Salir del juego
        Application.Quit();
    }
}
