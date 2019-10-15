using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueTrigger : MonoBehaviour
{

    public Dialogue dialogue;
    public static bool andar = true;
    public static bool movecamera = false;


    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.gameObject.tag == "player")
        {
            Time.timeScale = 0;
            TriggerDialogue();
            if (SceneManager.GetActiveScene().name != "Fase4")
            {
                andar = false;
            }
            else movecamera = true;
            this.gameObject.SetActive(false);
        } 
    }
  
}