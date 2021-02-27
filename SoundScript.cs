using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static AudioClip playerJumpSound, Playerdeath,coin;

    static AudioSource audio;

    void Start()
    {
        playerJumpSound = Resources.Load<AudioClip>("Jump");

        coin = Resources.Load<AudioClip>("Pickup_Coin4");

        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void playeffect(string clip)
    {
        switch (clip)
        {
        case "playerJumpSound":

                audio.PlayOneShot(playerJumpSound);
                break;
          
        case "Playerdeath":
                //audio.PlayOneShot(Playerdeath);
                break;

        case "coin":
                audio.PlayOneShot(coin);
                break;


        }
    }

}
