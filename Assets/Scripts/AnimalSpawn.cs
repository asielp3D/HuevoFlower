using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawn : MonoBehaviour
{
    public GameObject animalPrefabLago1;
    public GameObject animalPrefabLago2;
    public GameObject animalPrefabCamp1;
    public GameObject animalPrefabCamp2;
    public GameObject animalPrefabNieve1;
    public GameObject animalPrefabNieve2;
    public Transform spawnPosition;

     void Start()
    {
        string selectedAnimal = PlayerPrefs.GetString("SelectedAnimal");

        if (selectedAnimal == "lago_1")
        {
            Instantiate(animalPrefabLago1, spawnPosition.position, Quaternion.identity);
        }
        else if (selectedAnimal == "lago_2")
        {
            Instantiate(animalPrefabLago2, spawnPosition.position, Quaternion.identity);
        }
        else if (selectedAnimal == "camp_1")
        {
            Instantiate(animalPrefabCamp2, spawnPosition.position, Quaternion.identity);
        }
        else if (selectedAnimal == "camp_2")
        {
            Instantiate(animalPrefabCamp2, spawnPosition.position, Quaternion.identity);
        }
        else if (selectedAnimal == "nieve_1")
        {
            Instantiate(animalPrefabNieve2, spawnPosition.position, Quaternion.identity);
        }
        else if (selectedAnimal == "nieve_2")
        {
            Instantiate(animalPrefabNieve2, spawnPosition.position, Quaternion.identity);
        }
    }
}
