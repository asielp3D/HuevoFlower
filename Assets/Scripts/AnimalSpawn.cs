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

        if (selectedAnimal == "Animal_lago")
        {
            Instantiate(animalPrefabLago1, spawnPosition.position, Quaternion.identity);
        }
        else if (selectedAnimal == "Animal_lago_2")
        {
            Instantiate(animalPrefabLago2, spawnPosition.position, Quaternion.identity);
        }
        else if (selectedAnimal == "Animal_campamento")
        {
            Instantiate(animalPrefabCamp1, spawnPosition.position, Quaternion.identity);
        }
        else if (selectedAnimal == "Animal_campamento_2")
        {
            Instantiate(animalPrefabCamp2, spawnPosition.position, Quaternion.identity);
        }
        else if (selectedAnimal == "Animal_nieve")
        {
            Instantiate(animalPrefabNieve1, spawnPosition.position, Quaternion.identity);
        }
        else if (selectedAnimal == "Animal_nieve_2")
        {
            Instantiate(animalPrefabNieve2, spawnPosition.position, Quaternion.identity);
        }
    }
}
