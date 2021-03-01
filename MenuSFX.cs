using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSFX : MonoBehaviour
{
    public static AudioClip playsound, exitsound, optionsound, creditsound;

    static AudioSource audiop;
    // Start is called before the first frame update
    void Start()
    {
        playsound = Resources.Load<AudioClip>("Menu Sounds 01");

        exitsound = Resources.Load<AudioClip>("Bloop 06");

        optionsound = Resources.Load<AudioClip>("Menu Sounds 04");

        creditsound = Resources.Load<AudioClip>("Menu Sounds 02");

        audiop = GetComponent<AudioSource>();
    }

    public  void play()
    {
        audiop.PlayOneShot(playsound);
    }

    public  void exit()
    {
        audiop.PlayOneShot(exitsound);
    }

    public void credits()
    {
        audiop.PlayOneShot(creditsound);
    }

    public void options()
    {
        audiop.PlayOneShot(optionsound);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
