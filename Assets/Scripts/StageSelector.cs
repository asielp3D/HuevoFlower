using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelector : MonoBehaviour
{
    public string stage;

    void OnMouseDown()
    {
        switch (stage)
        {
            case "lago":
                PlayerPrefs.SetString("SelectedAnimal", "Animal_lago");
                SceneManager.LoadScene(2);
            break;
            case "nieve":
                if(GameManager.instance.huevoLago[0] && GameManager.instance.huevoLago[1])
                {
                    PlayerPrefs.SetString("SelectedAnimal", "Animal_nieve");
                    SceneManager.LoadScene(2);
                }
            break;
            case "campamento":
                if(GameManager.instance.huevoLago[0] && GameManager.instance.huevoLago[1] &&
                    GameManager.instance.huevoNieve[0] && GameManager.instance.huevoNieve[1])
                {
                    PlayerPrefs.SetString("SelectedAnimal", "Animal_campamento");
                    SceneManager.LoadScene(2);
                }
            break;
        }
    }
}
