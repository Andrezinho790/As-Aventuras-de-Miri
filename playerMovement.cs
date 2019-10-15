using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    public  AudioClip playerJump,itemCollected,youLose,youWin;
    public  AudioSource audioSrc;
    
    public GameObject musicaDeFundo;
    public static string audioName;
    public Animator ganhou;
    public Animator gameOver;
    private Animator anim;
    public GameObject cam;
    string valueItems;
    string valueItems2;
    string valueItems3;
    public Text itensColetados;
    private int itemsCollected3 = 0;
    private int itemsCollected = 0;
    private int itemsCollected2 = 0;
    private bool isGrounded = true;
    public Rigidbody2D rb;
    private float jumForce = 8;
    // Start is called before the first frame update
    void Start()
    {
        
        anim = GetComponent<Animator>();
        itensColetados.color = new Color(255, 0, 0, 255);
    }

    // Update is called once per frame
    void Update()
    {
        
        HeWin();
        Walk();
        valueItems = Mathf.Floor(itemsCollected).ToString("0");
        valueItems2 = Mathf.Floor(itemsCollected2).ToString("0");
        valueItems3 = Mathf.Floor(itemsCollected3).ToString("0");
        Jump();
        UpdateNumberOfItems();
    }


    void HeWin()
    {
        if (itemsCollected >= 8 || itemsCollected2 >= 17 || itemsCollected3 >= 20)
        {
            PlaySound("youWin");
            ganhou.SetBool("IsOpen", true);
            Time.timeScale = 0;
        }
    }
    void Jump()
    {
        if (isGrounded)
        {
            
            if (DialogueTrigger.andar == false)
            {
                Debug.Log("entrou aqui");
                if (Input.touchCount > 0 && DialogueManager.canJump == true || Input.GetButton("Fire1") && DialogueManager.canJump == true )
                {
                    
                    PlaySound("jump");
                    
                    isGrounded = false;
                    rb.AddForce(Vector2.up * jumForce, ForceMode2D.Impulse);
                    anim.SetBool("IsJumping", true);
                    
                }
            }
        }
    }

    public  void PlaySound(string clip)
    {
        if (clip == "jump")
        {

            audioSrc.PlayOneShot(playerJump);

        }
        if (clip == "gotItem")
        {

            audioSrc.PlayOneShot(itemCollected);

        }
        if (clip == "youLose")
        {

            audioSrc.PlayOneShot(youLose);

        }
        if (clip == "youWin")
        {
            Destroy(musicaDeFundo);
            audioSrc.PlayOneShot(youWin);
            
        }
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
       
        if(collision.gameObject.tag == "ground" )
        {
            anim.SetBool("IsJumping", false);
            isGrounded = true;
            Debug.Log("chao");
        }
        if (collision.gameObject.tag == "enemy" || collision.gameObject.tag == "lava" || collision.gameObject.tag == "agua")
        {
            PlaySound("youLose");
            gameOver.SetBool("IsOpen", true);
            Time.timeScale = 0;

        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "item")
        {
            PlaySound("gotItem");
            Destroy(collision.gameObject);
            itemsCollected++;
            
        }
        if (collision.gameObject.tag == "itens2")
        {
            PlaySound("gotItem");
            Destroy(collision.gameObject);
            itemsCollected2++;

        }
        if (collision.gameObject.tag == "itens3")
        {
            PlaySound("gotItem");
            Destroy(collision.gameObject);
            itemsCollected3++;

        }



    }
    void UpdateNumberOfItems()
    {
        if (SceneManager.GetActiveScene().name == "Fase1")
        {
            itensColetados.text = "Peças coletadas: " + valueItems + "/8";
        }
        if (SceneManager.GetActiveScene().name == "Fase2")
        {
            itensColetados.text = "Coletados: " + valueItems2 + "/17";
        }
        if (SceneManager.GetActiveScene().name == "Fase3")
        {
            itensColetados.text = "Coletadas: " + valueItems3 + "/20";
        }
    }
    public void Walk()
    {
        if(DialogueTrigger.andar == true)
        {
            anim.SetBool("SlowWalking", true);
            transform.Translate(Vector2.right * 1 * Time.deltaTime);
        }
        if (DialogueTrigger.andar == false)
        {
            anim.SetBool("SlowWalking", false);
            
        }
    }
}
