using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public bool[] huevoLago;
    public bool[] huevoNieve;
    public bool[] huevoCampamento;

    void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        for (int i = 0; i < huevoLago.Length; i++)
        {
            huevoLago[i] = PlayerPrefs.GetString("HuevoLago" + i , "false") == "true";
        }

        for (int i = 0; i < huevoNieve.Length; i++)
        {
            huevoNieve[i] = PlayerPrefs.GetString("HuevoNieve" + i , "false") == "true";
        }

        for (int i = 0; i < huevoCampamento.Length; i++)
        {
            huevoCampamento[i] = PlayerPrefs.GetString("HuevoCampamento" + i , "false") == "true";
        }
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            PlayerPrefs.DeleteAll();
        }
    }

}
