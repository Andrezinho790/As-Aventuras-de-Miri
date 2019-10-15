using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mastodonte : MonoBehaviour
{


    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        Walk();

    }












    public void Walk()
    {
        if (DialogueTrigger.andar == true)
        {

            transform.Translate(Vector2.right * 1 * Time.deltaTime);
        }

    }
}
