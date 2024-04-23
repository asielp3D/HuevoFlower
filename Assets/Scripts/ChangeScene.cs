using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Nombre de la escena a la que queremos cambiar
    public string sceneName;

    // Método que se ejecuta cuando se pulsa el objeto
    void OnMouseDown()
    {
        // Cargar la escena con el nombre especificado
        SceneManager.LoadScene(1);
    }
}
