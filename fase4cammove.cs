using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fase4cammove : MonoBehaviour
{
    public GameObject botao;
    public Image fim;
    // Start is called before the first frame update
    void Start()
    {
        fim.canvasRenderer.SetAlpha(0);
    }

    // Update is called once per frame
    void Update()
    {
        if(DialogueTrigger.movecamera == true)
        {
            transform.Translate(Vector3.right * Time.deltaTime * 2);
            fadeIn();
            StartCoroutine(botaoRecomecar());
        }

    }
    public void fadeIn()
    {
        if (DialogueManager.fimfade == true)
        {
            fim.CrossFadeAlpha(1, 6, true);
        }
    }

    IEnumerator botaoRecomecar()
    {
       
        yield return new WaitForSeconds(6);
        botao.SetActive(true);

    }
}
