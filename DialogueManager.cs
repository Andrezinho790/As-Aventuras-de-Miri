using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{
    
    private Text nome;
    public static bool canJump = false;
    public Text nameText;
    public Text dialogueText;
    public static bool fimfade = false;
    public Animator objetivoAnim;
    public Animator animator;

    private Queue<string> sentences;

    // Use this for initialization
    void Start()
    {
        
        sentences = new Queue<string>();
    }


    public void DisplayNextSentence()
    {
        if (SceneManager.GetActiveScene().name == "Fase4")
        {
            if (sentences.Count == 6)
            {
                nameText.text = "Miri";
            }
            else if (sentences.Count == 5)
            {
                nameText.text = "Humano Primitivo";
            }
            else if (sentences.Count == 4)
            {
                nameText.text = "Mastodonte";
            }
            else if (sentences.Count == 3)
            {
                nameText.text = "Humano Primitivo";
            }
            else if (sentences.Count == 2)
            {
                nameText.text = "Miri";
            }
            else if (sentences.Count == 1)
            {
                nameText.text = "Mastodonte";
            }






        }
        else
        {
            if (sentences.Count == 2)
            {
                nameText.text = "Irritator";
            }
            else
            {
                nameText.text = "Miri";
            }
        }
        if (sentences.Count == 0)
        {
            
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }
    public void StartDialogue(Dialogue dialogue)
    {

        animator.SetBool("IsOpen", true);

        nameText.text = dialogue.name;

        sentences.Clear();

        
        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        
        DisplayNextSentence();
    }



    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    } 

    void EndDialogue()
    {
        
        fimfade = true;
        Time.timeScale = 1;
        Debug.Log("ending ");
        animator.SetBool("IsOpen", false);
        objetivoAnim.SetBool("IsOpen", true);
        canJump = true;
    }


}

