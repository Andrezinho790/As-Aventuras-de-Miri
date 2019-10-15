using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyIrritator : MonoBehaviour
{
    void Update()
    {
        Walk();
        goBack();

    }










    public void goBack()
    {
        if(transform.position.x <= -11f)
        {
            transform.position = new Vector3(30f, transform.position.y, transform.position.z);
        }
    }

    public void Walk()
    {
        if (DialogueTrigger.andar == true)
        {

            transform.Translate(Vector2.right * 1 * Time.deltaTime);
        }
        if (DialogueTrigger.andar == false)
        {

            transform.Translate(Vector2.right * -7f * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "agua")
        {
            goBack();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "barreirainvisivel")
        {
            transform.position = new Vector3(30f, transform.position.y, transform.position.z);
        }
    }
}
