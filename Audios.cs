using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audios : MonoBehaviour
{
    public AudioClip jumpAudio;
    public  static AudioClip playerJump;//playerDie, win, itemCollect;
    public static  AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {


        playerJump = jumpAudio;
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void PlaySoundJump(string clip)
    {
        if (clip == "jump")
        {

            audioSrc.PlayOneShot(playerJump);

        }
    }
}
