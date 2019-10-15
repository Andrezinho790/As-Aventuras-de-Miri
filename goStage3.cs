using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goStage3 : MonoBehaviour

{
    public GameObject musica;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void goStage()
    {
        Destroy(musica);
        SceneManager.LoadScene("Fase3");
    }
}
