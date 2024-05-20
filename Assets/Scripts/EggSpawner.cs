using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggSpawner : MonoBehaviour
{
    public GameObject eggPrefabLago1;
    public GameObject eggPrefabLago2;
    public GameObject eggPrefabCamp1;
    public GameObject eggPrefabCamp2;
    public GameObject eggPrefabNieve1;
    public GameObject eggPrefabNieve2;
    public Transform spawnPosition;

    void Start()
    {
        string selectedEgg = PlayerPrefs.GetString("SelectedEgg");

        if (selectedEgg == "lago_1")
        {
            Instantiate(eggPrefabLago1, spawnPosition.position, Quaternion.identity);
        }
        else if (selectedEgg == "lago_2")
        {
            Instantiate(eggPrefabLago2, spawnPosition.position, Quaternion.identity);
        }
        else if (selectedEgg == "camp_1")
        {
            Instantiate(eggPrefabCamp2, spawnPosition.position, Quaternion.identity);
        }
        else if (selectedEgg == "camp_2")
        {
            Instantiate(eggPrefabCamp2, spawnPosition.position, Quaternion.identity);
        }
        else if (selectedEgg == "nieve_1")
        {
            Instantiate(eggPrefabNieve2, spawnPosition.position, Quaternion.identity);
        }
        else if (selectedEgg == "nieve_2")
        {
            Instantiate(eggPrefabNieve2, spawnPosition.position, Quaternion.identity);
        }
    }
}