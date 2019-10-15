using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class comecarbtn : MonoBehaviour
{
    public GameObject descricao;
    public GameObject background;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {


    }
    
    public void comecarGame()
    {

        background.SetActive(false);
        descricao.SetActive(false);
    }



}
