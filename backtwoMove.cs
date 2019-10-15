using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backtwoMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (DialogueTrigger.andar == false)
        {
            transform.Translate(-3 * Time.deltaTime, 0, 0);
        }
    }
}
