using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscenarioSpawner : MonoBehaviour
{
    public GameObject eggPrefab1;
    public GameObject eggPrefab2;
    public Transform spawnPosition;

    void Start()
    {
        string selectedEgg = PlayerPrefs.GetString("SelectedEgg");

        if (selectedEgg == "huevo_azul")
        {
            Instantiate(eggPrefab1, spawnPosition.position, Quaternion.identity);
        }
        else if (selectedEgg == "huevo_rojo")
        {
            Instantiate(eggPrefab2, spawnPosition.position, Quaternion.identity);
        }
    }
}
