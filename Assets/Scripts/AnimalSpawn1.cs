using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawn : MonoBehaviour
{
    public GameObject[] huevosPrefabLago;
    public GameObject[] huevosPrefabNieve;
    public GameObject[] huevosPrefabCampamento;
    public Transform[] huevosLagoSpawn;
    public Transform[] huevosNieveSpawn;
    public Transform[] huevosCampamentoSpawn;

    public GameObject[] animalesPrefabLago;
    public GameObject[] animalesPrefabNieve;
    public GameObject[] animalesPrefabCampamento;
    public Transform[] spawnPosition;

     void Start()
    {
        string selectedAnimal = PlayerPrefs.GetString("SelectedAnimal");

        switch (selectedAnimal)
        {
            case "Animal_lago":
                for (int i = 0; i < GameManager.instance.huevoLago.Length; i++)
                {
                    if(GameManager.instance.huevoLago[i] == true)
                    {
                        Instantiate(animalesPrefabLago[i], spawnPosition[i].position, Quaternion.identity);
                    }
                    else
                    {
                        Instantiate(huevosPrefabLago[i], huevosLagoSpawn[i].position, Quaternion.identity);
                    }
                }
            break;
            case "Animal_nieve":
                for (int i = 0; i < GameManager.instance.huevoNieve.Length; i++)
                {
                    if(GameManager.instance.huevoNieve[i] == true)
                    {
                        Instantiate(animalesPrefabNieve[i], spawnPosition[i].position, Quaternion.identity);
                    }
                    else
                    {
                        Instantiate(huevosPrefabNieve[i], huevosNieveSpawn[i].position, Quaternion.identity);
                    }
                }
            break;
            case "Animal_campamento":
                for (int i = 0; i < GameManager.instance.huevoCampamento.Length; i++)
                {
                    if(GameManager.instance.huevoCampamento[i] == true)
                    {
                        Instantiate(animalesPrefabCampamento[i], spawnPosition[i].position, Quaternion.identity);
                    }
                    else
                    {
                        Instantiate(huevosPrefabCampamento[i], huevosCampamentoSpawn[i].position, Quaternion.identity);
                    }
                }
            break;
        }
    }
}
