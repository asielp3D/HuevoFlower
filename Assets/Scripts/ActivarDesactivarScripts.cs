using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarDesactivarScripts : MonoBehaviour
{
    public MonoBehaviour EggSelection; // Referencia al script actualmente activo
    public MonoBehaviour huevo; // Referencia al script actualmente desactivado

    void Start()
    {
        // Desactivar el script activo al inicio del juego
        EggSelection.enabled = false;
        
        // Activar el script desactivado al inicio del juego
        huevo.enabled = true;
    }

    public void CambiarScripts()
    {
        // Desactivar el script activo
        EggSelection.enabled = false;
        
        // Activar el script desactivado
        huevo.enabled = true;

        // Intercambiar las referencias para futuras operaciones
        MonoBehaviour temp = EggSelection;
        EggSelection = huevo;
        huevo = temp;
    }
}
