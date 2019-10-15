using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class dataFadeIn : MonoBehaviour
{
    public GameObject desc, local;
    public Image dataLocal;
    // Start is called before the first frame update
    void Start()
    {
        
        dataLocal.canvasRenderer.SetAlpha(0.0f);
        
    }

    private void Update()
    {
        Debug.Log(dataLocal.canvasRenderer.GetAlpha());
        StartCoroutine(fadeInOut(3));
    }
    public void fadeIn()
    {
        Time.timeScale = 1;
        dataLocal.CrossFadeAlpha(1, 3, true);
        
    }
     IEnumerator fadeInOut(float tempo)
    {

        if (dataLocal.canvasRenderer.GetAlpha() == 1f)
        {
            yield return new WaitForSecondsRealtime(tempo);

            dataLocal.CrossFadeAlpha(0, 2, true);

            yield return new WaitForSecondsRealtime(2);

            //Time.timeScale = 1;
            yield return new WaitForSecondsRealtime(1);
            desc.SetActive(false);
            local.SetActive(false);
            
        }
    }
}
