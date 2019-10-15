using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuAudio : MonoBehaviour
{


    bool tocarAudio = true;
    private static MenuAudio instance = null;

    public static MenuAudio Instance
    {
        get
        {
            return instance;

        }
    }
    // Start is called before the first frame update
    void Awake()
    {
        if (tocarAudio)
        {
            if (instance != null && instance != this)
            {
                Destroy(this.gameObject);
                return;
            }
            else
            {
                instance = this;
            }

            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        /* if (SceneManager.GetActiveScene().name != "MainMenu" && SceneManager.GetActiveScene().name != "SelectScreen" && SceneManager.GetActiveScene().name != "OsRangers")
        {
            Destroy(this.gameObject);
            tocarAudio = false;
            //Debug.Log(tocarAudio);
        } */


    }

}
