using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundMove : MonoBehaviour
{

    void Update()
    {
        if (DialogueTrigger.andar == false)
        {
            transform.Translate(-4 * Time.deltaTime, 0, 0);
        }
    }
}
