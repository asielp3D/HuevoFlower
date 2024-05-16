using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscenarioSpawn : MonoBehaviour
{
    public GameObject lagoPrefab;
    public GameObject nievePrefab;
    public GameObject campamentoPrefab;
    public Transform spawnPosition;
    

    void Start()
    {
        string selectedAnimal = PlayerPrefs.GetString("SelectedAnimal");

        if (selectedAnimal == "Animal_lago")
        {
            Instantiate(lagoPrefab, spawnPosition.position, Quaternion.identity);
        }
        else if (selectedAnimal == "Animal_nieve")
        {
            Instantiate(nievePrefab, spawnPosition.position, Quaternion.identity);
        }
        else if (selectedAnimal == "Animal_campamento")
        {
            Instantiate(campamentoPrefab, spawnPosition.position, Quaternion.identity);
        }
    }
    
}
