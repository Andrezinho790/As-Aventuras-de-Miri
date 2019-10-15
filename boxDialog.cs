using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boxDialog : MonoBehaviour
{
    
    public Text nome;
    public Image foto;
    public Sprite miri;
    public Sprite irritator;
    public Sprite mastodonte;
    public Sprite humanoprim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (nome.text == "Miri")
        {
            foto.GetComponent<Image>().sprite = miri;
        }else if(nome.text == "Irritator")
        {
            foto.GetComponent<Image>().sprite = irritator;
        }else if(nome.text == "Mastodonte")
        {
            foto.GetComponent<Image>().sprite = mastodonte;
        }else if(nome.text == "Humano Primitivo")
        {
            foto.GetComponent<Image>().sprite = humanoprim;
        }
    }
}
